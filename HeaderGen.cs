using System.Reflection;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using StringBuilder = System.Text.StringBuilder;

public static class Utils
{
    //~ long: String Helpers
    
    public const int indent = 4;
    
    public static StringBuilder AppendIndent(this StringBuilder builder, string str, int indentLevel)
    {
        return builder.Append(' ', indent * indentLevel).Append(str);
    }
    
    public static void AppendArray<T>(this StringBuilder builder, IList<T> list, string start, string end,
                                      Action<StringBuilder, T> action)
    {
        if (list.Count == 0) return;
        builder.Append(start);
        
        for (int i = 0; i < list.Count; ++i)
        {
            action(builder, list[i]);
            if (i < list.Count - 1)
                builder.Append(", ");
        }
        builder.Append(end);
    }
    
    public static string EscapeString(string str, char ignore)
    {
        StringBuilder builder = new StringBuilder(str.Length * 2);
        foreach (char c in str.Replace("\\", "\\\\"))
        {
            switch (c)
            {
                case '\0': builder.Append("\\0"); break;
                case '\a': builder.Append("\\a"); break;
                case '\b': builder.Append("\\b"); break;
                case '\f': builder.Append("\\f"); break;
                case '\n': builder.Append("\\n"); break;
                case '\r': builder.Append("\\r"); break;
                case '\t': builder.Append("\\t"); break;
                case '\v': builder.Append("\\v"); break;
                
                case '\"': builder.Append(ignore != '\"' ? "\\\"" : c); break;
                case '\'': builder.Append(ignore != '\'' ? "\\\'" : c); break;
                default:   builder.Append(c); break;
            }
        }
        return builder.ToString();
    }
    
    public static string Prefix(this string str, string prefix)
    {
        return prefix + (str != null ? " " + str : "");
    }
    
    //~ long: List Helpers
    
    public static IEnumerable<T> Iterate<T>(this T start, Func<T, T> next) where T : class
    {
        for (T elem = start; elem != null; elem = next(elem))
            yield return elem;
    }
    
    public static void AddRange<T, U>(this IList<T> list, ICollection<U> collection,
                                      System.Func<U, T> convert, System.Func<U, bool> canProcess = null)
    {
        if (list is List<T> realList)
        {
            if (realList.Capacity - realList.Count < collection.Count)
                realList.Capacity = collection.Count + realList.Count;
        }
        
        canProcess ??= _ => true;
        foreach (U item in collection)
            if (canProcess(item))
                list.Add(convert(item));
    }
    
    public static IList<T> AdvanceRange<T>(this IList<T> list, ref int index, int count, bool forward = false)
    {
        int oldIndex = index;
        index += count * (forward ? 1 : -1);
        int offset = forward ? oldIndex : index;
        
        IList<T> result;
        if (list is System.Array)
            result = new System.ArraySegment<T>((T[])list, offset, count);
        
        else
        {
            result = new List<T>(count);
            for (int i = offset; i < offset + count; ++i)
                result.Add(list[i]);
        }
        return result;
    }
}

public class HeaderGen
{
    //~ long: This class resolves conflicting names
    // By default, GetMemberName calls AddTypeName and gets back a reachable type
    // That type’s name is guaranteed not to conflict with any nested/outer/inherited types
    // But it may conflict with using directives or the current namespace
    // The problem is we don’t know which namespace a type needs until processing finishes
    // Because of that, AddTypeName prepends a delimiter before the name, which will be resolved later
    // If you want to reduce complexity and runtime overhead, don’t call Init
    // This will force AddTypeName to always append the full namespace
    
    public class NameResolver
    {
        public class CollisionEntry
        {
            public Type type;
            public Type targetType;
        }
        
        private List<CollisionEntry> usedTypes;
        private List<string> usedNamespaces;
        public Type currentType;
        
        private static ConcurrentDictionary<int, NameResolver> table;
        private static List<string> allNamespaces;
        
        //~ long: Setup Table
        
        private static NameResolver LookupData(bool insert)
        {
            // TODO(long): Although collisions are very rare, task identifiers are not guaranteed to be unique
            int key = Task.CurrentId ?? -1;
            
            if (insert && table != null)
                table.TryAdd(key, new NameResolver() {
                                 usedNamespaces = new List<string>(16),
                                 usedTypes = new List<CollisionEntry>(),
                             });
            
            return table?[key];
        }
        
        public static void Init(ICollection<Assembly> assemblies, int cap)
        {
            table = new ConcurrentDictionary<int, NameResolver>(32, cap);
            allNamespaces = new List<string>(256);
            
            foreach (Assembly assembly in assemblies)
                foreach (Type type in assembly.GetTypes())
                    if (!type.IsGenericParameter && type.Namespace != null && !allNamespaces.Contains(type.Namespace))
                        allNamespaces.Add(type.Namespace);
        }
        
        public static NameResolver CollisionDataForType(Type type, bool clear)
        {
            NameResolver data = LookupData(true);
            if (data != null)
            {
                data.currentType = type;
                
                if (clear)
                {
                    data.usedNamespaces.Clear();
                    data.usedTypes.Clear();
                }
            }
            return data;
        }
        
        //~ long: Push Entry
        // AddTypeName remembers any newly used namespace
        // It then retrieves the type name relative to the current enclosing type
        // Finally, it pushes an entry to the conflict-type list, prefixing it with the delimiter and index
        // Later, when all used namespaces are known, ParseTypeString appends the correct namespace
        // Rather than storing a list of conflicting types, you could preprocess to collect all namespaces
        // I tried this before, but it was annoying because the two functions were very similar
        // so any change to one required changing the other as well.
        
        public const string delimiter = "This is a delimiter that will be replaced later";
        
        public static string AddTypeName(Type type, MemberNameMode mode)
        {
            string name = GetTypeFullName(type);
            NameResolver data = LookupData(false);
            Type target = data?.currentType;
            
            if (target != null)
            {
                Type reachable = GetReachableType(type, target, mode);
                int dotIdx = reachable.FullName.LastIndexOfAny(new char[] { '.', '+' });
                name = name.Substring(dotIdx + 1);
                
                if (!reachable.IsGenericParameter && reachable != target && reachable.DeclaringType == null)
                {
                    string ns = reachable.Namespace;
                    if (ns != null && !data.usedNamespaces.Contains(ns))
                    {
                        string currNamespace = target.Namespace;
                        if (ns != currNamespace && currNamespace?.StartsWith(ns + ".") != true)
                            data.usedNamespaces.Add(ns);
                    }
                    
                    data.usedTypes.Add(new CollisionEntry { type = GetGenericDef(reachable), targetType = target });
                    name = delimiter + (data.usedTypes.Count - 1) + "#" + name;
                }
            }
            return name;
        }
        
        public string ParseTypeString(string text)
        {
            StringBuilder builder = new StringBuilder(text.Length);
            usedNamespaces.Sort();
            
            foreach (string ns in usedNamespaces)
                builder.Append("using ").Append(ns).Append(";\n");
            if (builder.Length != 0)
                builder.Append('\n');
            
            int start = 0, end = 0;
            while (true)
            {
                end = text.IndexOf(delimiter, start);
                if (end == -1)
                {
                    builder.Append(text.Substring(start));
                    break;
                }
                
                builder.Append(text.Substring(start, end - start));
                start = end + delimiter.Length;
                
                int endDelim = text.IndexOf('#', start);
                if (int.TryParse(text.Substring(start, Math.Max(endDelim - start, 0)), out int entryIdx))
                {
                    builder.Append(HandleNameCollision(usedTypes[entryIdx]));
                    start = endDelim + 1;
                }
                
                else
                {
                    // long: Place error handling here when the text contains the delimiter itself
                }
            }
            
            return builder.ToString();
        }
        
        //~ long: A type is reachable (can be directly refered to) in the current enclosing type when:
        // 1. Its DeclaringType is also the enclosing type or the enclosing type's parent
        // 2. Its DeclaringType is one of the enclosing type's base types
        // 3. It's one of the enclosing type's parent
        // 4. It's global
        
        private static Type GetReachableType(Type elemType, Type targetType, MemberNameMode mode)
        {
            //- long: Setup types
            Type currentType = GetGenericDef(elemType);
            
            // NOTE(long): Base types of a nested class resolve from the outer class first
            // While member lookups (including attributes) start from the nested class itself
            // Example:
            //   class A
            //   {
            //       [SomeAttribute(typeof(A))] // Refers to inner A
            //       class B : A                // Refers to outer A
            //       {
            //           class A { }
            //       }
            //   }
            // So if nested, set the target type to its parent AFTER resolving generic arguments
            bool isNested = targetType.IsNested;
            if (mode == MemberNameMode.BaseType && isNested)
                targetType = targetType.DeclaringType;
            
            Type baseType = null;
            IEnumerable<Type> baseTypes = GetInterfaces(targetType).Concat(targetType.BaseType.Iterate(t => t.BaseType));
            
            //- long: Search for the common parent
            // If types differ at i == 0, no common parent exists
            int commonIdx = 0;
            int nameCount = currentType.FullName.Count(c => c == '+');
            {
                string[] defNames = currentType.FullName.Split('+');
                string[] tarNames =  targetType.FullName.Split('+');
                
                for (; commonIdx < defNames.Length && commonIdx < tarNames.Length; ++commonIdx)
                    if (defNames[commonIdx] != tarNames[commonIdx])
                        break;
            }
            
            //- long: Ascend from the current type to find a reachable type
            for (; commonIdx < nameCount; ++commonIdx, currentType = currentType.DeclaringType)
            {
                if (mode == MemberNameMode.BaseType && !isNested) continue;
                
                // Scan the inheritance tree to see if any base type contains the type
                baseType = baseTypes.FirstOrDefault(type => {
                                                        string baseName = GetGenericDef(type).FullName;
                                                        return baseName == currentType.FullName ||
                                                            baseName == currentType.DeclaringType?.FullName;
                                                    });
                
                // If it does, the target type can access it directly => this becomes the new reachable type
                if (baseType != null)
                    break;
            }
            
            // If there is no common parent, sharedParent is null and currentType is the outermost type
            Type sharedParent = currentType.DeclaringType;
            
            //- long: Traverse upward from the shared parent until the generic arguments diverge
            if (sharedParent != null)
            {
                Type[] currentArgs = elemType.GetGenericArguments();
                Type[] targetArgs = (baseType ?? targetType).GetGenericArguments();
                Type parent = sharedParent;
                
                for (int endIndex = parent.GetGenericArguments().Length; endIndex > 0; parent = parent.DeclaringType)
                {
                    int startIndex = endIndex - GenericArgumentsFromType(parent).Length;
                    for (int i = startIndex; i < endIndex && currentType != parent; ++i)
                        if (currentArgs[i] != targetArgs[i])
                            currentType = parent;
                    endIndex = startIndex;
                }
            }
            
            //- long: Type Collision
            Type result = currentType;
            if (currentType.FullName != targetType.FullName)
                for (; result.DeclaringType != null; result = result.DeclaringType)
                    if (!NameResolver.HasTypeCollision(result.Name, GetTypeFullName(result), targetType, out _))
                        break;
            
            return result;
        }
        
        //~ long: HandleNameCollision only appends the shortest namespace
        // AddTypeName has already found the shortest relative name
        // This function handles only global types, disambiguating them against used namespaces
        
        private static string HandleNameCollision(CollisionEntry entry)
        {
            Type currentType = entry.type;
            Type targetType = entry.targetType;
            string[] tarNames = targetType.Namespace?.Split('.') ?? new string[0];
            
            bool isGlobal = false;
            string name = currentType.Namespace;
            
            if (!HasNamespaceCollision(currentType.Name, GetTypeFullName(currentType)))
                name = "";
            else if (name == null)
                isGlobal = true;
            
            //- long: Namespace Collision
            else
            {
                string[] curNames = name.Split('.');
                int length = Math.Min(curNames.Length, tarNames.Length);
                IEnumerable<int> sharedNs = Enumerable.Range(0, length).TakeWhile((_, i) => curNames[i] == tarNames[i]);
                
                // NOTE(long): If sharedNs is empty, nsIdx will be -1
                int nsIdx = sharedNs.Reverse().FirstOrDefault(ns => !HasNamespaceCollision(curNames[ns], name), -1);
                if (nsIdx >= 0)
                    name = string.Join('.', curNames.Skip(nsIdx));
                else if (HasTypeCollision(curNames[0], name, targetType, out _))
                    isGlobal = true;
                
                name += '.';
            }
            
            return isGlobal ? "global::" + name : name;
            
            // NOTE(long): Check if the name conflicts with a global namespace or the target type's namespaces
            bool HasNamespaceCollision(string name, string fullname)
            {
                bool collide = HasTypeCollision(name, fullname, targetType, out bool isReachable);
                if (!isReachable)
                {
                    if (!collide)
                        collide = fullname != targetType.Namespace && tarNames.Any(ns => ns == name);
                    
                    if (!collide)
                        collide = allNamespaces.Any(ns => ns.Split('.')[0] == name);
                }
                return collide;
            }
        }
        
        // NOTE(long): Checks if a name conflicts with any reachable type in the current enclosing type
        private static bool HasTypeCollision(string name, string fullname, Type targetType, out bool isReachable)
        {
            isReachable = false;
            
            // NOTE(long): Scan outward from targetType (t => t.DeclaringType)
            // For each type, walk up BaseType chain checking for a nested type with the same name
            var localTypes = targetType.Iterate(t => t.DeclaringType)
                .SelectMany(o => o.Iterate(t => GetBaseType(t)).Select(t => t.GetNestedType(name, flags)).Prepend(o));
            
            // NOTE(long): Scan outward from the targetType's namespace
            // Also scan the System namespace for built-in types
            // For each namespace, search for a global type with the same name
            string[] namespaces = targetType.Namespace?.Split('.') ?? new string[0];
            var globalTypes = Enumerable.Range(0, namespaces.Length + 1).Reverse()
                .Select(cnt => string.Join('.', namespaces.Take(cnt)) + (cnt > 0 ? "." : ""))
                .Append("System.").Select(ns => HeaderGen.GetType(ns + name));
            
            // NOTE(long): The order here matters
            var reachableTypes = localTypes.Concat(globalTypes).Where(t => t != null && GetTypeAccess(t) < maxAccess);
            
            foreach (Type type in reachableTypes)
            {
                isReachable = fullname == GetTypeFullName(type);
                if (isReachable) return false;
                if (name == type.Name) return true;
            }
            
            return false;
        }
        
        private static string GetTypeFullName(Type type)
        {
            type = GetGenericDef(type);
            string result = type.FullName?.Replace('+', '.');
            
            if (result == null)
            {
                // NOTE(long): Type.FullName may be null when the type is a generic type
                // that is not a generic type definition and still has unresolved type parameters
                // In such cases, I must manually assemble the full name (namespace.outer.inner)
                // https://learn.microsoft.com/en-us/archive/blogs/haibo_luo/type-fullname-returns-null-when
                Debug.Assert(type.IsGenericType && !type.IsGenericTypeDefinition && type.ContainsGenericParameters);
                
                IEnumerable<string> names = type.Iterate(t => t.DeclaringType).Select(t => t.Name).Reverse();
                if (type.Namespace != null)
                    names = names.Prepend(type.Namespace);
                
                result = string.Join('.', names);
            }
            return result;
        }
    }
    
    //~ NOTE(long): Main API
    
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    // NOTE(long): This is in decreased restrictive level order (protected and internal have the same level)
    public enum AccessModifier
    {
        None,
        Public,            // Default for interface members
        ProtectedInternal,
        Protected,
        Internal,          // Default for global types (declared directly within a namespace)
        PrivateProtected,  // (since C# 7.2)
        Private,           // Default for members (including nested types)
    }
    
    public static readonly string[] AccessModifierString =
    {
        "None",
        "public",
        "protected internal",
        "protected",
        "internal",
        "private protected",
        "private",
    };
    
    public enum MemberNameMode
    {
        Default,
        NoGenericParameter,
        NoAttributePostfix,
        IsDecl,
        BaseType,
    }
    
    public class MemberData
    {
        public MemberNameMode mode;
        public IList<string> tupleNames;
        public int nameIdx;
    }
    
    // NOTE(long) Classes cannot inherit from or contain members of less-permissive types
    // => VS only displays types/members with "displayable" modifiers (public, protected internal, protected)
    // However, types/members can implement or have non-displayable nested interfaces/attributes
    // => In such cases, VS only shows definitions for global types and usages for nested types
    public const BindingFlags flags = BindingFlags.Public|BindingFlags.NonPublic|
        BindingFlags.Instance|BindingFlags.Static|BindingFlags.DeclaredOnly;
    public const AccessModifier maxAccess = AccessModifier.Protected;
    
    const string  compilerNamespace = "System.Runtime.CompilerServices.";
    const string unmanagedAttribute = compilerNamespace + "IsUnmanagedAttribute";
    const string       refAttribute = compilerNamespace + "IsByRefLikeAttribute";
    const string  readonlyAttribute = compilerNamespace + "IsReadOnlyAttribute";
    const string extensionAttribute = compilerNamespace + "ExtensionAttribute";
    const string     paramAttribute = "System.ParamArrayAttribute";
    
    public static Task DumpType(string path, Type type, string data)
    {
        string dir = path;
        if (type.Namespace != null)
            dir = Path.Combine(dir, type.Namespace);
        Directory.CreateDirectory(dir);
        
        string filename = GetNameWithoutGeneric(type.Name);
        {
            filename = Path.Combine(dir, filename);
            int genericCount = type.GetGenericArguments().Length;
            if (genericCount > 0)
                filename += "`" + genericCount;
            filename += ".cs";
        }
        
        string location = type.Assembly.Location;
        if (string.IsNullOrEmpty(location))
            location = "location unknown";
        return File.WriteAllTextAsync(filename, $"#region {type.Assembly.FullName}\n// {location}\n#endregion\n\n{data}");
    }
    
    public static string GetGlobalType(Type type)
    {
        string result = null;
        if (type.IsPublic)
        {
            NameResolver data = NameResolver.CollisionDataForType(type, true);
            StringBuilder builder = new StringBuilder(256);
            
            if (type.Namespace != null)
            {
                builder.Append("namespace ").Append(type.Namespace).Append("\n{\n");
                AppendMemberDefinition(builder, type, 1);
                builder.Append("}\n");
            }
            else AppendMemberDefinition(builder, type, 0);
            
            result = builder.ToString();
            if (data != null)
                result = data.ParseTypeString(result);
        }
        return result;
    }
    
    static void AppendMemberDefinition(StringBuilder builder, MemberInfo member, int indent)
    {
        FieldInfo field = member as FieldInfo;
        PropertyInfo property = member as PropertyInfo;
        EventInfo eventInfo = member as EventInfo;
        MethodBase method = member as MethodBase;
        Type type = member as Type;
        
        //~ long: Filter Name
        bool skip = false;
        switch (member.MemberType)
        {
            case MemberTypes.Method: skip = method.IsSpecialName && !member.Name.StartsWith("op_"); break;
            case MemberTypes.Field:  skip = ((FieldInfo)member).IsSpecialName;                      break;
            
            // NOTE(long): We (and VS) can't tell if an empty constructor was declared or compiler-generated
            // https://stackoverflow.com/questions/3190575/detect-compiler-generated-default-constructor-using-reflection-in-c-sharp
            case MemberTypes.Constructor: break;
        }
        if (skip) return;
        
        // NOTE(long): All user-defined delegates inherit from MulticastDelegate, not Delegate
        // Therefore, we avoid `typeof(Delegate).IsAssignableFrom(type)`, since it also matches Delegate and MulticastDelegate
        bool isDelegate = type != null && type.IsSubclassOf(typeof(MulticastDelegate));
        
        //~ long: Retrieve Special Method
        MethodInfo getter = null, setter = null;
        {
            switch (member.MemberType)
            {
                case MemberTypes.Property:
                {
                    getter = property.GetGetMethod(true);
                    setter = property.GetSetMethod(true);
                    
                    // 1. An accessor can only be more restrictive than its property
                    // 2. A property needs both getter and setter to give either a custom access modifier
                    // => A property's access level is either the less restrictive of its accessors, or the only one it has
                    if (getter != null && setter != null)
                        method = GetMethodAccess(getter) <= GetMethodAccess(setter) ? getter : setter;
                    else
                        method = getter ?? setter;
                } break;
                
                case MemberTypes.Event:
                {
                    // NOTE(long): C# events always have both add and remove method, but never raise method
                    method = eventInfo.GetAddMethod(true);
                } break;
                
                case MemberTypes.NestedType: goto case MemberTypes.TypeInfo;
                case MemberTypes.TypeInfo:
                {
                    if (isDelegate)
                        method = type.GetMethod("Invoke");
                } break;
            }
        }
        
        //~ NOTE(long): Restrictive Level
        AccessModifier access = AccessModifier.None;
        
        if (field != null)
        {
            if (false) { }
            else if (field.IsPublic)            access = AccessModifier.Public;
            else if (field.IsFamilyOrAssembly)  access = AccessModifier.ProtectedInternal;
            else if (field.IsFamily)            access = AccessModifier.Protected;
            else if (field.IsAssembly)          access = AccessModifier.Internal;
            else if (field.IsFamilyAndAssembly) access = AccessModifier.PrivateProtected;
            else if (field.IsPrivate)           access = AccessModifier.Private;
        }
        
        else if (type   != null) access = GetTypeAccess(type);
        else if (method != null) access = GetMethodAccess(method);
        
        //~ long: Filter Restrictive Level
        if (access > maxAccess)
            return;
        if (GetCustomAttribute<UnsafeValueTypeAttribute>(member) != null)
            return;
        
        string name = GetMemberName(member, MemberNameMode.IsDecl);
        MethodInfo methodInfo = method as MethodInfo;
        
        //~ long: Attributes
        string attributes = null;
        {
            IList<CustomAttributeData> data = member.GetCustomAttributesData();
            IList<CustomAttributeData> returnAtts = new List<CustomAttributeData>();
            if (member.MemberType == MemberTypes.Method)
                returnAtts = methodInfo.ReturnParameter.GetCustomAttributesData();
            
            StringBuilder attributeBuider = new StringBuilder((data.Count + returnAtts.Count) * 16);
            AppendAttributes(attributeBuider, data, indent);
            AppendAttributes(attributeBuider, returnAtts, indent, "return");
            
            // NOTE(long): Could also apply to [field], [property], [event], or a delegate's return param
            // But VS doesn't show those either, so not worth it
            // Same for [assembly] and [module] attributes: I never care
            attributes = attributeBuider.ToString();
        }
        
        // https://codeblog.jonskeet.uk/2014/08/22/when-is-a-constant-not-a-constant-when-its-a-decimal/
        var decimalConst = GetCustomAttribute<DecimalConstantAttribute>(field);
        var fixedAttr = GetCustomAttribute<FixedBufferAttribute>(field);
        
        Type parentType = member.DeclaringType;
        bool isEnumMember = parentType?.IsEnum == true;
        bool ignoreDeclare = name[0] == '~' || isEnumMember;
        bool ignoreModify = ignoreDeclare || parentType?.IsInterface == true;
        
        //~ long: Modifiers
        string modifier = null;
        if (ignoreModify)
        {
            // NOTE(long): Still need to set the modifier here for AppendDefaultValue to work
            if (isEnumMember)
                modifier = "const";
        }
        
        //- long: Type Modifiers
        else if (type != null)
        {
            // abstract  -> class, method, property, indexer, event
            // static    -> field, class, method, property, operator, constructor, event
            // virtual   -> method, property, indexer, event
            // override  -> inherited method, property, indexer, event
            // sealed    -> inherited class, or anything marked override
            // const     -> fields
            // readonly  -> fields, structs, parameters
            // ref       -> structs, parameters, and ref(readonly) returns (method, property, indexer, delegate)
            // event     -> delegates
            
            if (!type.IsInterface && !type.IsEnum && !isDelegate)
            {
                if (type.IsAbstract && type.IsSealed)
                    modifier = "static";
                else if (type.IsAbstract) // interfaces are also IsAbstract
                    modifier = "abstract";
                else if (!type.IsValueType && type.IsSealed) // value types (struct, enum, etc) are sealed by default
                    modifier = "sealed";
                
                else
                {
                    if (HasAttribute(type.CustomAttributes, readonlyAttribute))
                        modifier = "readonly";
                    if (HasAttribute(type.CustomAttributes, refAttribute))
                        modifier = modifier.Prefix("ref");
                }
            }
        }
        
        else if (field != null)
        {
            if (field.IsLiteral || decimalConst != null)
                modifier = "const";
            else if (field.IsInitOnly && field.IsStatic)
                modifier = "static readonly";
            else if (field.IsInitOnly)
                modifier = "readonly";
            else if (field.IsStatic)
                modifier = "static";
            
            if (fixedAttr != null)
                modifier = modifier.Prefix("unsafe fixed");
        }
        
        else if (method != null)
        {
            //  virtual -> isVirtual !isFinal (because interfaces are virtual and final)
            // override -> isVirtual baseMethod != method (sealed: IsFinal)
            // abstract -> isVirtual isAbstract
            //   static -> isStatic
            
            // NOTE(long): VS doesn't handle the new modifier
            if (method.IsStatic)
                modifier = "static";
            
            if (method.IsVirtual)
            {
                // TODO(long): `static abstract/virtual/sealed` members in interfaces (C# 11)
                if (IsMethodOverride(methodInfo))
                    modifier = method.IsFinal ? "sealed override" : "override";
                else if (method.IsAbstract)
                    modifier = "abstract";
                else if (!method.IsFinal)
                    modifier = "virtual";
            }
            
            if (GetCustomAttribute<AsyncStateMachineAttribute>(method) != null)
                modifier = modifier.Prefix("async");
        }
        
        //~ long: Declare Type
        string declare = null;
        if (!ignoreDeclare)
        {
            Type declareType = null;
            ParameterInfo returnParam = methodInfo?.ReturnParameter;
            
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                {
                    if (fixedAttr != null)
                        declareType = fixedAttr.ElementType;
                    else
                        declareType = field.FieldType;
                } break;
                
                case MemberTypes.Event:
                {
                    declare = "event ";
                    declareType = eventInfo.EventHandlerType;
                } break;
                
                case MemberTypes.Property:
                {
                    if (getter != null)
                        returnParam = getter.ReturnParameter;
                    else
                        declareType = property.PropertyType;
                } break;
                
                case MemberTypes.Method:
                {
                    if (method.IsSpecialName)
                    {
                        string methodName = method.Name;
                        if (methodName == "op_Implicit" || methodName == "op_Explicit")
                        {
                            declare = (methodName == "op_Implicit" ? "implicit" : "explicit") + " operator";
                            returnParam = null;
                        }
                        
                        else if (methodName == "op_CheckedImplicit" || methodName == "op_CheckedExplicit")
                        {
                            declare = (methodName == "op_CheckedImplicit" ? "implicit" : "explicit") + " operator checked";
                            returnParam = null;
                        }
                    }
                } break;
                
                case MemberTypes.TypeInfo: goto case MemberTypes.NestedType;
                case MemberTypes.NestedType:
                {
                    if (false) { }
                    else if (isDelegate)       declare = "delegate ";
                    else if (type.IsEnum)      declare = "enum";
                    else if (type.IsClass)     declare = "class";
                    else if (type.IsInterface) declare = "interface";
                    else if (type.IsValueType) declare = "struct";
                } break;
            }
            
            if (returnParam != null && declareType == null)
            {
                declare += GetParameterModifier(returnParam, returnParam.GetCustomAttributesData());
                declareType = returnParam.ParameterType;
            }
            
            if (declareType != null)
                declare += GetTypeName(declareType, field != null ? field : returnParam);
        }
        
        //~ long: Values/Arguments
        string value = null;
        {
            StringBuilder valueBuilder = new StringBuilder(256);
            
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                {
                    if (modifier == "const")
                    {
                        valueBuilder.Append(" = ");
                        object constVal = decimalConst?.Value ?? field.GetRawConstantValue();
                        AppendDefaultValue(valueBuilder, field.FieldType, constVal, MemberNameMode.IsDecl);
                    }
                    
                    else if (modifier == "unsafe fixed")
                        valueBuilder.Append($"[{fixedAttr.Length}]");
                } break;
                
                case MemberTypes.Property:
                {
                    AppendArrayValue(property.GetIndexParameters(), "[", "]", AppendParameter);
                    valueBuilder.Append(" {");
                    AccessModifier methodAccess = GetMethodAccess(method);
                    AppendAccessor(getter, "get");
                    AppendAccessor(setter, "set");
                    valueBuilder.Append(" }");
                    
                    void AppendAccessor(MethodInfo accessorMethod, string accessorName)
                    {
                        if (accessorMethod != null)
                        {
                            AccessModifier accessorAccess = GetMethodAccess(accessorMethod);
                            if (accessorAccess <= maxAccess)
                            {
                                valueBuilder.Append(' ');
                                if (accessorAccess > methodAccess)
                                    valueBuilder.Append(AccessModifierString[(int)accessorAccess]).Append(' ');
                                valueBuilder.Append(accessorName).Append(';');
                            }
                        }
                    }
                } break;
                
                case MemberTypes.Constructor: goto case MemberTypes.Method;
                case MemberTypes.Method:
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    if (parameters.Length == 0)
                        valueBuilder.Append("()");
                    AppendArrayValue(parameters, "(", ")", AppendParameter);
                } break;
                
                case MemberTypes.TypeInfo: goto case MemberTypes.NestedType;
                case MemberTypes.NestedType:
                {
                    if (isDelegate)
                        goto case MemberTypes.Method;
                    
                    AppendArrayValue(GetBaseTypes(type), " : ", null, AppendBaseType);
                    static void AppendBaseType(StringBuilder builder, Type baseType)
                    {
                        string name = GetMemberName(baseType, MemberNameMode.BaseType);
                        builder.Append(name);
                    }
                    
                    valueBuilder.Append('\n');
                    valueBuilder.AppendIndent("{\n", indent);
                    
                    // NOTE(long): Members order (newline):
                    // fields -> constructors -> finalizers -> properties -> events -> methods
                    // -> operators -> conversion operators -> nested types -> delegates
                    MemberInfo[] members = type.GetMembers(flags);
                    IEnumerable<MemberInfo>[] table = new IEnumerable<MemberInfo>[]
                    {
                        members.Where(m => m.MemberType == MemberTypes.Field),
                        members.Where(m => m.MemberType == MemberTypes.Constructor),
                        members.Where(m => m.MemberType == MemberTypes.Method && m.Name == "Finalize"),
                        members.Where(m => m.MemberType == MemberTypes.Property).OrderBy(m => !IsIndexer((PropertyInfo)m)),
                        members.Where(m => m.MemberType == MemberTypes.Event),
                        members.Where(m => IsMethodSpecial(m, special: false, equal: false, "Finalize")),
                        members.Where(m => IsMethodSpecial(m, special: true , equal: false, "op_Implicit", "op_Explicit")),
                        members.Where(m => IsMethodSpecial(m, special: true , equal: true , "op_Implicit", "op_Explicit")),
                        members.Where(m => m.MemberType == MemberTypes.NestedType),
                    };
                    
                    // NOTE(long): After some profiling, iterating through the array multiple times is slightly faster than sorting
                    for (int i = 0; i < table.Length; ++i)
                    {
                        int length = valueBuilder.Length;
                        
                        foreach (MemberInfo mem in table[i])
                        {
                            Type targetType = mem.MemberType == MemberTypes.NestedType ? (Type)mem : type;
                            NameResolver data = NameResolver.CollisionDataForType(targetType, false);
                            AppendMemberDefinition(valueBuilder, mem, indent + 1);
                            if (data != null)
                                data.currentType = type; // restore the current scoped type
                        }
                        
                        if (valueBuilder.Length > length && i < table.Length - 1)
                            valueBuilder.Insert(length, '\n');
                    }
                    
                    valueBuilder.AppendIndent("}", indent);
                    
                    static bool IsMethodSpecial(MemberInfo member, bool special, bool equal, params string[] names)
                    {
                        MethodInfo method = member as MethodInfo;
                        if (method == null || method.IsSpecialName != special)
                            return false;
                        
                        foreach (string name in names)
                            if (name == method.Name)
                                return equal;
                        return !equal;
                    }
                } break;
            }
            
            value = valueBuilder.ToString();
            
            void AppendArrayValue<T>(T[] array, string start, string end, Action<StringBuilder, T> each)
            {
                valueBuilder.AppendArray(array, start, end, each);
                
                Type[] args = GenericArgumentsFromMember(member);
                for (int i = 0; i < args.Length; ++i)
                {
                    if (!args[i].IsGenericParameter)
                        continue;
                    
                    Type[] constraints = args[i].GetGenericParameterConstraints();
                    List<string> constraintNames = new List<string>(constraints.Length + 2);
                    
                    bool hasStruct = false;
                    foreach (Type constraint in constraints)
                    {
                        if (constraint == typeof(ValueType))
                            hasStruct = true;
                        else
                            constraintNames.Add(GetMemberName(constraint));
                    }
                    
                    // NOTE(long): Can't mix class/struct/unmanaged/notnull/default (C# 9 adds `default`)
                    // unmanaged implies struct, struct also implies new() and NotNullableValueTypeConstraint
                    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraintNames-on-type-parameters
                    if (HasAttribute(args[i].CustomAttributes, unmanagedAttribute))
                        constraintNames.Add("unmanaged");
                    else if (hasStruct)
                        constraintNames.Add("struct");
                    
                    else
                    {
                        GenericParameterAttributes attribute = args[i].GenericParameterAttributes;
                        if ((attribute & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
                            constraintNames.Add("class");
                        if ((attribute & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
                            constraintNames.Add("new()");
                    }
                    
                    // NOTE(long): Skips notnull because the docs are fuzzy and I don't use nullable context
                    
                    valueBuilder.AppendArray(constraintNames, $" where {args[i].Name} : ", null, (sb, str) => sb.Append(str));
                }
            }
        }
        
        //~ long: Append to builder
        builder.Append(attributes);
        builder.AppendIndent(null, indent);
        
        if (!ignoreModify)
        {
            builder.Append(AccessModifierString[(int)access]).Append(' ');
            if (modifier != null)
                builder.Append(modifier).Append(' ');
        }
        
        if (declare != null)
            builder.Append(declare).Append(' ');
        
        builder.Append(name);
        if (value != null)
            builder.Append(value);
        
        if (member.MemberType != MemberTypes.Property && (type == null || isDelegate))
        {
            if (!isEnumMember)
                builder.Append(';');
            
            // NOTE(long): In .NET 6 and earlier versions, the GetFields method doesn't return fields in a particular order
            // However, since .NET 7, the ordering is deterministic based upon the metadata ordering in the assembly
            // Metadata order may often coincide with declaration order in simple cases, but cannot be relied upon
            // On the other hand, even though the CLI spec doesn't promise it, MetadataToken follows declaration order
            else if (parentType.GetFields(flags).OrderBy(f => f.MetadataToken).Last() != member)
                builder.Append(',');
        }
        builder.Append('\n');
    }
    
    public static string GetMemberName(MemberInfo member, MemberNameMode mode = MemberNameMode.Default)
    {
        return GetMemberName(member, new MemberData { mode = mode });
    }
    
    public static string GetTypeName(Type type, ICustomAttributeProvider provider)
    {
        return GetMemberName(type, new MemberData { tupleNames = GetTupleNames(provider) });
    }
    
    public static string GetMemberName(MemberInfo member, MemberData data)
    {
        string name = member.Name;
        Type type = member as Type;
        
        // https://stackoverflow.com/questions/19788010/which-c-sharp-type-names-are-special
        switch (member.MemberType)
        {
            case MemberTypes.Constructor: name = GetNameWithoutGeneric(member.DeclaringType.Name); break;
            
            case MemberTypes.Method:
            {
                MethodBase method = (MethodBase)member;
                string methodName = member.Name;
                bool checkedOp = method.IsSpecialName && member.Name.StartsWith("op_Checked");
                if (checkedOp)
                    methodName = methodName.Replace("Checked", "");
                
                if (!method.IsSpecialName)
                {
                    if (methodName == "Finalize" && IsMethodOverride((MethodInfo)method))
                        name = "~" + GetNameWithoutGeneric(member.DeclaringType.Name);
                    // NOTE(long): operators, accessors, finalizer, and constructors can't be generic
                    else if (method.IsGenericMethod)
                        name = GetGenericName(GenericArgumentsFromMethod(method), methodName, (builder, param) =>
                                              {
                                                  if (data.mode == MemberNameMode.IsDecl && param.IsGenericParameter)
                                                      if (AppendAttributes(builder, param.GetCustomAttributesData(), -1))
                                                          builder.Append(' ');
                                                  AppendType(builder, param, data);
                                              });
                }
                
                // https://stackoverflow.com/questions/11113259/how-to-call-custom-operator-with-reflection
                else if (methodName == "op_UnaryPlus")          name = "operator +";
                else if (methodName == "op_UnaryNegation")      name = "operator -";
                else if (methodName == "op_Increment")          name = "operator ++";
                else if (methodName == "op_Decrement")          name = "operator --";
                else if (methodName == "op_LogicalNot")         name = "operator !";
                else if (methodName == "op_Addition")           name = "operator +";
                else if (methodName == "op_Subtraction")        name = "operator -";
                else if (methodName == "op_Multiply")           name = "operator *";
                else if (methodName == "op_Division")           name = "operator /";
                else if (methodName == "op_BitwiseAnd")         name = "operator &";
                else if (methodName == "op_BitwiseOr")          name = "operator |";
                else if (methodName == "op_ExclusiveOr")        name = "operator ^";
                else if (methodName == "op_OnesComplement")     name = "operator ~";
                else if (methodName == "op_Equality")           name = "operator ==";
                else if (methodName == "op_Inequality")         name = "operator !=";
                else if (methodName == "op_LessThan")           name = "operator <";
                else if (methodName == "op_GreaterThan")        name = "operator >";
                else if (methodName == "op_LessThanOrEqual")    name = "operator <=";
                else if (methodName == "op_GreaterThanOrEqual") name = "operator >=";
                else if (methodName == "op_LeftShift")          name = "operator <<";
                else if (methodName == "op_RightShift")         name = "operator >>";
                else if (methodName == "op_Modulus")            name = "operator %";
                else if (methodName == "op_True")               name = "operator true";
                else if (methodName == "op_False")              name = "operator false";
                else if (methodName == "op_UnsignedRightShift") name = "operator >>>"; // NOTE(long): Added in C# 11
                
                else if (methodName == "op_Implicit" || methodName == "op_Explicit")
                {
                    type = ((MethodInfo)method).ReturnType;
                    data.mode = MemberNameMode.Default;
                }
                else Debug.Assert(false);
                
                if (checkedOp)
                    name = name.Replace("operator", "operator checked");
            } break;
            
            case MemberTypes.Property:
            {
                // NOTE(long): C# doesn't mark indexer names as special, even though they're always "Item"
                if (IsIndexer((PropertyInfo)member))
                    name = "this";
            } break;
        }
        
        //~ long: Conversion Operators and (Nested) Types
        if (type != null)
        {
            Type definitionType = GetElementType(type, out int arrayCount, out int pointerCount, out Type elementType);
            name = GetPrimitiveTypeName(elementType);
            
            //- long: Name at Declaration
            if (data.mode == MemberNameMode.IsDecl)
            {
                name = elementType.Name;
                if (elementType.IsGenericType)
                    name = GetGenericTypeName(elementType, name, data);
            }
            
            //- long: User-defined Types
            else if (name == null)
            {
                name = elementType.Name;
                
                //- long: Nullable Types
                if (definitionType == typeof(Nullable<>))
                    name = GetMemberName(GenericArgumentsFromType(elementType)[0], data.mode) + "?";
                
                //- long: Funciton pointers (C# 9)
                // Name, FullName, Namespace, AssemblyQualifiedName, and Assembly are always null
                else if (name == "")
                {
                    Debug.Assert(elementType.IsFunctionPointer);
                    StringBuilder builder = new StringBuilder();
                    builder.Append("delegate*");
                    
                    if (elementType.IsUnmanagedFunctionPointer)
                    {
                        builder.Append(" unmanaged");
                        // TODO(long): GetFunctionPointerCallingConventions
                    }
                    
                    // NOTE(long): typeArgs always contains at least one element (the return type)
                    List<Type> args = new List<Type>(elementType.GetFunctionPointerParameterTypes());
                    args.Add(elementType.GetFunctionPointerReturnType());
                    builder.AppendArray(args, "<", ">", (sb, arg) => AppendType(sb, arg, data));
                    name = builder.ToString();
                }
                
                //- long: Tuple Types
                else if (IsTuple(definitionType))
                {
                    // NOTE (long): A tuple can hold up to 8 items directly
                    // For more than 7, the 8th item is a nested tuple holding the rest (TRest)
                    List<Type> args = new List<Type>(8);
                    for (Type tuple = elementType; tuple != null; )
                    {
                        Type[] restArgs = GenericArgumentsFromType(tuple);
                        args.AddRange(restArgs);
                        tuple = null;
                        
                        if (restArgs.Length == 8)
                        {
                            Type last = restArgs[7];
                            if (IsTuple(last))
                            {
                                args.RemoveAt(args.Count - 1);
                                tuple = last;
                            }
                        }
                    }
                    
                    // NOTE(long): TransformNames contains a flat list of tuple element names as emitted by the C# compiler
                    // For tuples with >7 elements, Roslyn flattens the nested TRest and pads the list with nulls
                    // https://github.com/dotnet/roslyn/issues/19946
                    int baseIdx = data.nameIdx;
                    data.nameIdx += args.Count;
                    if (args.Count >= 8)
                        // This code skips over trailing null entries
                        // The TupleElementNamesAttribute of ValueTuple<int,int,...,(int x8, int x9)>
                        // differs from that of (int,int,...,int x8,int x9)
                        // This code displays nested tuples without names, like Visual Studio
                        data.nameIdx += args.Count - 8 + 1;
                    
                    IList<string> tupleNames = data.tupleNames;
                    bool hasName = tupleNames != null && tupleNames.Count > 0;
                    StringBuilder builder = new StringBuilder("(");
                    
                    for (int paramIdx = 0; paramIdx < args.Count; ++paramIdx)
                    {
                        AppendType(builder, args[paramIdx], data);
                        if (hasName && tupleNames[paramIdx + baseIdx] != null)
                            builder.Append(' ').Append(tupleNames[paramIdx + baseIdx]);
                        if (paramIdx < args.Count - 1)
                            builder.Append(", ");
                    }
                    
                    builder.Append(")");
                    name = builder.ToString();
                }
                
                //- long: Normal Types
                else if (definitionType.FullName != null)
                {
                    name = NameResolver.AddTypeName(elementType, data.mode);
                    
                    // NOTE(long): At this point, the name is prefixed with a delimiter
                    // This is fine because these routines will iterate the names backward
                    if (data.mode == MemberNameMode.NoAttributePostfix && name.EndsWith("Attribute"))
                        name = name.Substring(0, name.Length - "Attribute".Length);
                    else if (elementType.IsGenericType) // NOTE(long): attributes can't be generic
                        name = GetGenericTypeName(elementType, name, data);
                }
            }
            
            //- long: Type Suffix
            if (pointerCount > 0 || arrayCount > 0)
            {
                StringBuilder builder = new StringBuilder(name, name.Length + "*".Length * pointerCount + "[]".Length * arrayCount);
                for (int i = 0; i < pointerCount; ++i)
                    builder.Append("*");
                for (int i = 0; i < arrayCount; ++i)
                    builder.Append("[]");
                name = builder.ToString();
            }
        }
        
        return name;
        
        //~ NOTE(long): Type Name Helpers
        
        static string GetGenericTypeName(Type type, string name, MemberData data)
        {
            string[] names = name.Split('.');
            int nameIdx = names.Length - 1;
            
            Type[] genericArgs = type.GetGenericArguments();
            int genericIdx = genericArgs.Length;
            
            Action<StringBuilder, Type> action = (builder, param) =>
            {
                if (data.mode == MemberNameMode.IsDecl && param.IsGenericParameter)
                    if (AppendAttributes(builder, param.GetCustomAttributesData(), -1))
                        builder.Append(' ');
                
                if (data.mode != MemberNameMode.NoGenericParameter || !param.IsGenericParameter)
                    AppendType(builder, param, data);
            };
            
            for (Type parent = type; nameIdx >= 0 && genericIdx > 0; parent = parent.DeclaringType, --nameIdx)
            {
                IList<Type> args = genericArgs.AdvanceRange(ref genericIdx, GenericArgumentsFromType(parent).Length);
                // NOTE(long): Generic methods don't use ` in names, but generic types do (probably for overloads)
                names[nameIdx] = GetGenericName(args, GetNameWithoutGeneric(names[nameIdx]), action);
            }
            
            return string.Join(".", names);
        }
        
        static string GetGenericName(IList<Type> args, string name, Action<StringBuilder, Type> action,
                                     string open = "<", string close = ">")
        {
            StringBuilder builder = new StringBuilder(name);
            builder.AppendArray(args, open, close, action);
            return builder.ToString();
        }
    }
    
    //~ NOTE(long): Append Functions
    
    static void AppendType(StringBuilder builder, Type type, MemberData data)
    {
        builder.Append(GetMemberName(type, data));
    }
    
    static void AppendParameter(StringBuilder builder, ParameterInfo param)
    {
        IList<CustomAttributeData> attributes = param.GetCustomAttributesData();
        if (AppendAttributes(builder, attributes, -1))
            builder.Append(' ');
        builder.Append(GetParameterModifier(param, attributes));
        
        Type paramType = param.ParameterType.IsByRef ? param.ParameterType.GetElementType() : param.ParameterType;
        builder.Append(GetTypeName(paramType, param));
        builder.Append(' ').Append(param.Name);
        if (param.HasDefaultValue)
            AppendDefaultValue(builder.Append(" = "), paramType, param.RawDefaultValue);
    }
    
    static bool AppendAttributes(StringBuilder builder, IList<CustomAttributeData> data, int indent, string target = null)
    {
        string terminator = "\n";
        if (indent == -1)
        {
            indent = 0;
            terminator = null;
        }
        
        bool hasAtt = false;
        foreach (CustomAttributeData attr in data.OrderBy(att => att.AttributeType.Name))
        {
            if (IsAttIgnoredByVS(attr.AttributeType.FullName))
                continue;
            
            builder.AppendIndent("[", indent);
            if (target != null)
                builder.Append(target).Append(": ");
            builder.Append(GetMemberName(attr.AttributeType, MemberNameMode.NoAttributePostfix));
            
            List<CustomAttributeTypedArgument> args = GetAttributeArguments(attr);
            int ctorCount = attr.ConstructorArguments.Count;
            int argIdx = 0;
            builder.AppendArray(args, "(", ")", (sb, arg) =>
                                {
                                    if (argIdx >= ctorCount)
                                        sb.Append(attr.NamedArguments[argIdx - ctorCount].MemberName).Append(" = ");
                                    AppendDefaultValue(sb, arg.ArgumentType, arg.Value);
                                    ++argIdx;
                                });
            
            builder.Append(']').Append(terminator);
            hasAtt = true;
        }
        
        return hasAtt;
    }
    
    static void AppendDefaultValue(StringBuilder builder, Type valueType, object value,
                                   MemberNameMode mode = MemberNameMode.Default)
    {
        // NOTE(long): Constant fields and parameters can only default to string or built-in primitives
        // Attributes follow the same rule but also allow System.Type, object, and 1D arrays of those
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/attributes#2124-attribute-parameter-types
        if (value != null)
        {
            string str = value.ToString();
            
            // https://learn.microsoft.com/en-us/dotnet/api/system.reflection.customattributetypedargument.value?view=net-7.0
            if (value is ReadOnlyCollection<CustomAttributeTypedArgument> args)
            {
                builder.Append("new[] {");
                builder.AppendArray(args, null, null, (sb, arg) => AppendDefaultValue(sb, arg.ArgumentType, arg.Value));
                builder.Append(" }");
            }
            // NOTE(long): Tuple types are appended with () instead of ValueTuple, unlike the Visual Studio style
            else if (valueType == typeof(Type))
                builder.Append($"typeof({GetMemberName((Type)value, MemberNameMode.NoGenericParameter)})");
            
            else if (valueType.IsEnum && mode != MemberNameMode.IsDecl)
            {
                // NOTE(long): This is retarded. Turns out null isn't the billion-dollar mistake, exceptions are.
                static ulong CS_Is_Retarded(object obj)
                {
                    try { return Convert.ToUInt64(obj); }
                    catch (OverflowException) { return (ulong)Convert.ToInt64(obj); }
                }
                
                string typeName = GetMemberName(valueType);
                ulong enumVal = CS_Is_Retarded(value);
                ulong  oldVal = enumVal;
                
                // NOTE(long): This code is a bit complex because it must handle composite flags (e.g. ReadWrite = Read|Write)
                // First, we sort in descending order to match them, then sort again ascending to restore order
                List<string> valNames = Enum.GetValues(valueType).Cast<Enum>().Select(CS_Is_Retarded).OrderDescending()
                    .Where(f => {
                               if ((enumVal & f) == f)
                               {
                                   enumVal -= f;
                                   
                                   // NOTE(long): 0 is allowed only when the value is not a flag (i.e. only one item can be valid)
                                   // The list is sorted, so reaching zero means all other values have already been tried
                                   return f != 0 || oldVal == enumVal;
                               }
                               
                               return false;
                           }).Order().Select(f => $"{typeName}.{Enum.GetName(valueType, f)}").ToList();
                
                if (enumVal != 0 || valNames.Count == 0)
                    valNames.Add(enumVal.ToString());
                builder.AppendJoin(" | ", valNames);
            }
            
            else if (valueType == typeof(string))
                builder.Append($"\"{Utils.EscapeString(str, '\'')}\"");
            else if (valueType == typeof(char))
                builder.Append($"\'{Utils.EscapeString(str, '\"')}\'");
            else
                builder.Append(str);
            
            float? flt = null;
            try { flt = Convert.ToSingle(value); } catch (Exception) { /* NOTE(long): Ignore */ }
            if (flt == null || Math.Abs((float)flt % 1) <= float.Epsilon) { }
            
            else if (valueType == typeof(float))
                builder.Append("F");
            else if (valueType == typeof(decimal))
                builder.Append("M");
        }
        else builder.Append("null");
    }
    
    //~ NOTE(long): Method Helpers
    
    public static bool IsIndexer(PropertyInfo property) => property.GetIndexParameters().Length > 0;
    public static bool IsMethodOverride(MethodInfo method) =>
        method.IsVirtual && (method.Attributes & MethodAttributes.NewSlot) == 0;
    public static bool IsTuple(Type type) => GetNameWithoutGeneric(type.Name) == "ValueTuple" &&
        type.Namespace == "System" && type.IsGenericType;
    
    public static AccessModifier GetMethodAccess(MethodBase method)
    {
        if (method.IsPublic)            return AccessModifier.Public;
        if (method.IsFamilyOrAssembly)  return AccessModifier.ProtectedInternal;
        if (method.IsFamily)            return AccessModifier.Protected;
        if (method.IsAssembly)          return AccessModifier.Internal;
        if (method.IsFamilyAndAssembly) return AccessModifier.PrivateProtected;
        if (method.IsPrivate)           return AccessModifier.Private;
        return AccessModifier.None;
    }
    
    public static AccessModifier GetTypeAccess(Type type)
    {
        AccessModifier access = AccessModifier.None;
        
        // NOTE(long): Global types can only be declared as public or internal
        if (!type.IsNested) access = type.IsPublic ? AccessModifier.Public : AccessModifier.Internal;
        
        else if (type.IsNestedPublic)      access = AccessModifier.Public;
        else if (type.IsNestedAssembly)    access = AccessModifier.Internal;
        else if (type.IsNestedPrivate)     access = AccessModifier.Private;
        
        // NOTE(long): Struct types and their members cannot use the following modifiers
        else if (type.IsNestedFamily)      access = AccessModifier.Protected;
        else if (type.IsNestedFamORAssem)  access = AccessModifier.ProtectedInternal;
        else if (type.IsNestedFamANDAssem) access = AccessModifier.PrivateProtected;
        
        return access;
    }
    
    public static string GetParameterModifier(ParameterInfo param, IList<CustomAttributeData> attributes)
    {
        string modifier = null;
        if (HasAttribute(attributes, paramAttribute))
            modifier = "params ";
        else if (param.IsOut)
            modifier = "out ";
        else if (param.IsIn)
            modifier = "in ";
        else if (param.ParameterType.IsByRef)
            modifier = "ref " + (HasAttribute(attributes, readonlyAttribute) ? "readonly " : "");
        
        if (HasAttribute(param.Member.CustomAttributes, extensionAttribute) && param.Position == 0)
            modifier += "this ";
        else if (HasAttribute(attributes, compilerNamespace + "ScopedRefAttribute")) // C# 11
            modifier = "scoped " + modifier;
        return modifier;
    }
    
    //~ NOTE(long): Type Helpers
    
    public static Type GetType(string fullname)
    {
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        Type type = assemblies.Select(asm => asm.GetType(fullname)).FirstOrDefault(t => t != null);
        return type;
    }
    
    public static string GetPrimitiveTypeName(Type type)
    {
        if (type == typeof(bool))    return "bool";
        if (type == typeof(byte))    return "byte";
        if (type == typeof(sbyte))   return "sbyte";
        if (type == typeof(short))   return "short";
        if (type == typeof(ushort))  return "ushort";
        if (type == typeof(int))     return "int";
        if (type == typeof(uint))    return "uint";
        if (type == typeof(long))    return "long";
        if (type == typeof(ulong))   return "ulong";
        if (type == typeof(char))    return "char";
        if (type == typeof(decimal)) return "decimal";
        if (type == typeof(double))  return "double";
        if (type == typeof(float))   return "float";
        if (type == typeof(string))  return "string";
        if (type == typeof(object))  return "object";
        if (type == typeof(void))    return "void";
        
        // NOTE(long): C# 9.0
        if (type == typeof(nint))    return "nint";
        if (type == typeof(nuint))   return "nuint";
        return null;
    }
    
    public static Type GetElementType(Type type, out int arrayCount, out int pointerCount, out Type elementType)
    {
        if (type.IsByRef)
            type = type.GetElementType();
        
        for (arrayCount = 0; type.IsArray; ++arrayCount)
            type = type.GetElementType();
        for (pointerCount = 0; type.IsPointer; ++pointerCount)
            type = type.GetElementType();
        
        // NOTE(long): Prior C# 11, pointers to managed types (e.g. int[]*) were disallowed
        // Since then, the compiler only warns instead of errors
        // It's rare and hardly used, so I ignore it
        // https://github.com/dotnet/runtime/discussions/82664#discussioncomment-5111868
        Debug.Assert(!type.IsArray);
        
        elementType = type;
        return GetGenericDef(type);
    }
    
    public static IEnumerable<Type> GetInterfaces(Type type) => type?.GetTypeInfo().ImplementedInterfaces;
    
    public static Type GetBaseType(Type type)
    {
        if (type.BaseType != null && type.BaseType != typeof(object) && !type.IsValueType)
            return type.BaseType;
        return null;
    }
    
    public static Type[] GetBaseTypes(Type type)
    {
        if (type.IsEnum)
            return new Type[0];
        
        Type baseType = GetBaseType(type);
        IEnumerable<Type> baseInterfaces = GetInterfaces(baseType) ?? Enumerable.Empty<Type>();
        IEnumerable<Type> currInterfaces = GetInterfaces(type).Except(baseInterfaces);
        
#if false
        // NOTE(long): This would exclude any interface inherited via another interface
        // What I actually want is to retrieve only the interfaces declared *directly* on the type
        // AFAIK, C# reflection doesn’t expose this directly, even though the assembly metadata contains it
        // e.g. System.Text.RegularExpressions.RegexMatchTimeoutException (ISerializable)
        // https://stackoverflow.com/questions/9793242/type-getinterfaces-for-declared-interfaces-only
        IEnumerable<Type> others = currInterfaces;
        currInterfaces = currInterfaces.Where(itf => !others.Any(other => other != itf && itf.IsAssignableFrom(other)));
#endif
        
        currInterfaces = currInterfaces.OrderBy(itf => itf.Name);
        if (baseType != null)
            currInterfaces = currInterfaces.Prepend(baseType);
        return currInterfaces.ToArray();
    }
    
    public static bool IsAttIgnoredByVS(string fullname)
    {
        if (fullname == "System.Runtime.Versioning.NonVersionableAttribute" ||
            fullname == "System.SerializableAttribute" || fullname == paramAttribute)
            return true;
        
        string  interop = "System.Runtime.InteropServices.";
        string diagnose = "System.Diagnostics.";
        if (fullname == interop + "UnmanagedFunctionPointer" || fullname.StartsWith(interop + "Marshalling.") ||
            fullname == diagnose + "ConditionalAttribute")
            return false;
        
        if (fullname.StartsWith(interop) || fullname.StartsWith(compilerNamespace) || fullname.StartsWith(diagnose))
            return true;
        return false;
    }
    
    //~ NOTE(long): Attribute Helper
    
    public static bool HasAttribute(IEnumerable<CustomAttributeData> attributes, string fullname)
    {
        foreach (var attribute in attributes)
            if (attribute.AttributeType.FullName == fullname)
                return true;
        return false;
    }
    
    public static List<CustomAttributeTypedArgument> GetAttributeArguments(CustomAttributeData attribute)
    {
        List<CustomAttributeTypedArgument> result = new List<CustomAttributeTypedArgument>(attribute.ConstructorArguments);
        result.AddRange(attribute.NamedArguments, arg => arg.TypedValue);
        return result;
    }
    
    public static T GetCustomAttribute<T>(System.Reflection.ICustomAttributeProvider provider,
                                          bool inherit = false) where T : Attribute
    {
        object[] attributes = provider?.GetCustomAttributes(typeof(T), inherit);
        if (attributes != null && attributes.Length > 0)
            return (T)attributes[0];
        return null;
    }
    
    public static IList<string> GetTupleNames(ICustomAttributeProvider provider)
    {
        return GetCustomAttribute<TupleElementNamesAttribute>(provider)?.TransformNames;
    }
    
    //~ NOTE(long): Generic Helpers
    
    public static Type GetGenericDef(Type type) => type.IsGenericType ? type.GetGenericTypeDefinition() : type;
    
    public static Type[] GenericArgumentsFromType(Type type)
    {
        Type[] args = new Type[0];
        if (type.IsGenericType == true)
        {
            // https://stackoverflow.com/questions/19503905/type-generictypearguments-property-vs-type-getgenericarguments-method
            args = type.GetGenericArguments();
            
            if (type.IsNested)
            {
                // NOTE(long): Outer class generic arguments always come before nested class arguments
                Type[] outerArgs = type.DeclaringType.GetGenericArguments();
                args = args.Skip(outerArgs.Length).ToArray();
            }
        }
        
        return args;
    }
    
    public static Type[] GenericArgumentsFromMethod(MethodBase method)
    {
        // void DoA<T>() { }             definition-generic-containsParameters
        // DoA<int>();                   generic (but nested members will never have this case)
        // class A<T> { void DoA() { } } containsParameters (The Invoke method of delegates falls into this case)
        // GetGenericArguments will never return T for A<T>.DoA()
        // https://stackoverflow.com/questions/34247315/c-sharp-reflection-how-to-determine-if-parameterinfo-is-a-generic-type-defined
        
        Type[] args = new Type[0];
        if (method.IsGenericMethod == true)
            args = method.GetGenericArguments();
        return args;
    }
    
    public static Type[] GenericArgumentsFromMember(MemberInfo member)
    {
        Type type = member as Type;
        if (type != null)
            return GenericArgumentsFromType(type);
        
        MethodBase method = member as MethodBase;
        if (method != null)
            return GenericArgumentsFromMethod(method);
        
        return new Type[0];
    }
    
    public static string GetNameWithoutGeneric(string name)
    {
        int idx = name.LastIndexOf('`');
        if (idx >= 0)
            name = name.Substring(0, idx);
        return name;
    }
}
