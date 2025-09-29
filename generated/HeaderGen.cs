#region HeaderGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\bin\Release\net8.0\HeaderGen.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

public class HeaderGen
{
    public static readonly string[] AccessModifierString;
    public const BindingFlags flags = 62;
    public const AccessModifier maxAccess = 3;

    public HeaderGen();

    public static Task DumpType(string path, Type type, string data);
    public static string GetGlobalType(Type type);
    public static string GetMemberName(MemberInfo member, MemberNameMode mode = MemberNameMode.Default);
    public static string GetTypeName(Type type, ICustomAttributeProvider provider);
    public static string GetMemberName(MemberInfo member, MemberData data);
    public static bool IsIndexer(PropertyInfo property);
    public static bool IsMethodOverride(MethodInfo method);
    public static bool IsTuple(Type type);
    public static AccessModifier GetMethodAccess(MethodBase method);
    public static AccessModifier GetTypeAccess(Type type);
    public static string GetParameterModifier(ParameterInfo param, IList<CustomAttributeData> attributes);
    public static Type GetType(string fullname);
    public static string GetPrimitiveTypeName(Type type);
    public static Type GetElementType(Type type, out int arrayCount, out int pointerCount, out Type elementType);
    public static IEnumerable<Type> GetInterfaces(Type type);
    public static Type GetBaseType(Type type);
    public static Type[] GetBaseTypes(Type type);
    public static bool IsAttIgnoredByVS(string fullname);
    public static bool HasAttribute(IEnumerable<CustomAttributeData> attributes, string fullname);
    public static List<CustomAttributeTypedArgument> GetAttributeArguments(CustomAttributeData attribute);
    public static T GetCustomAttribute<T>(ICustomAttributeProvider provider, bool inherit = False) where T : Attribute;
    public static IList<string> GetTupleNames(ICustomAttributeProvider provider);
    public static Type GetGenericDef(Type type);
    public static Type[] GenericArgumentsFromType(Type type);
    public static Type[] GenericArgumentsFromMethod(MethodBase method);
    public static Type[] GenericArgumentsFromMember(MemberInfo member);
    public static string GetNameWithoutGeneric(string name);

    public class NameResolver
    {
        public Type currentType;
        public const string delimiter = "";

        public NameResolver();

        public static void Init(ICollection<Assembly> assemblies, int cap);
        public static NameResolver CollisionDataForType(Type type, bool clear);
        public static string AddTypeName(Type type, MemberNameMode mode);
        public string ParseTypeString(string text);

        public class CollisionEntry
        {
            public Type type;
            public Type targetType;

            public CollisionEntry();
        }
    }
    public enum AccessModifier
    {
        None = 0,
        Public = 1,
        ProtectedInternal = 2,
        Protected = 3,
        Internal = 4,
        PrivateProtected = 5,
        Private = 6
    }
    public enum MemberNameMode
    {
        Default = 0,
        NoGenericParameter = 1,
        NoAttributePostfix = 2,
        IsDecl = 3,
        BaseType = 4
    }
    public class MemberData
    {
        public MemberNameMode mode;
        public IList<string> tupleNames;
        public int nameIdx;

        public MemberData();
    }
}
