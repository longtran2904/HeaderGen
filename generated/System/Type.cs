#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
    public abstract class Type : MemberInfo, IReflect
    {
        public static readonly char Delimiter;
        public static readonly Type[] EmptyTypes;
        public static readonly object Missing;
        public static readonly MemberFilter FilterAttribute;
        public static readonly MemberFilter FilterName;
        public static readonly MemberFilter FilterNameIgnoreCase;

        protected Type();

        public bool IsInterface { get; }
        public override MemberTypes MemberType { get; }
        public abstract string Namespace { get; }
        public abstract string AssemblyQualifiedName { get; }
        public abstract string FullName { get; }
        public abstract Assembly Assembly { get; }
        public abstract Module Module { get; }
        public bool IsNested { get; }
        public override Type DeclaringType { get; }
        public virtual MethodBase DeclaringMethod { get; }
        public override Type ReflectedType { get; }
        public abstract Type UnderlyingSystemType { get; }
        public virtual bool IsTypeDefinition { get; }
        public bool IsArray { get; }
        public bool IsByRef { get; }
        public bool IsPointer { get; }
        public virtual bool IsConstructedGenericType { get; }
        public virtual bool IsGenericParameter { get; }
        public virtual bool IsGenericTypeParameter { get; }
        public virtual bool IsGenericMethodParameter { get; }
        public virtual bool IsGenericType { get; }
        public virtual bool IsGenericTypeDefinition { get; }
        public virtual bool IsSZArray { get; }
        public virtual bool IsVariableBoundArray { get; }
        public virtual bool IsByRefLike { get; }
        public virtual bool IsFunctionPointer { get; }
        public virtual bool IsUnmanagedFunctionPointer { get; }
        public bool HasElementType { get; }
        public virtual Type[] GenericTypeArguments { get; }
        public virtual int GenericParameterPosition { get; }
        public virtual GenericParameterAttributes GenericParameterAttributes { get; }
        public TypeAttributes Attributes { get; }
        public bool IsAbstract { get; }
        public bool IsImport { get; }
        public bool IsSealed { get; }
        public bool IsSpecialName { get; }
        public bool IsClass { get; }
        public bool IsNestedAssembly { get; }
        public bool IsNestedFamANDAssem { get; }
        public bool IsNestedFamily { get; }
        public bool IsNestedFamORAssem { get; }
        public bool IsNestedPrivate { get; }
        public bool IsNestedPublic { get; }
        public bool IsNotPublic { get; }
        public bool IsPublic { get; }
        public bool IsAutoLayout { get; }
        public bool IsExplicitLayout { get; }
        public bool IsLayoutSequential { get; }
        public bool IsAnsiClass { get; }
        public bool IsAutoClass { get; }
        public bool IsUnicodeClass { get; }
        public bool IsCOMObject { get; }
        public bool IsContextful { get; }
        public virtual bool IsEnum { get; }
        public bool IsMarshalByRef { get; }
        public bool IsPrimitive { get; }
        public bool IsValueType { get; }
        public virtual bool IsSignatureType { get; }
        public virtual bool IsSecurityCritical { get; }
        public virtual bool IsSecuritySafeCritical { get; }
        public virtual bool IsSecurityTransparent { get; }
        public virtual StructLayoutAttribute StructLayoutAttribute { get; }
        public ConstructorInfo TypeInitializer { get; }
        public virtual RuntimeTypeHandle TypeHandle { get; }
        public abstract Guid GUID { get; }
        public abstract Type BaseType { get; }
        public static Binder DefaultBinder { get; }
        [Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual bool IsSerializable { get; }
        public virtual bool ContainsGenericParameters { get; }
        public bool IsVisible { get; }

        public static Type GetType(string typeName, bool throwOnError, bool ignoreCase);
        public static Type GetType(string typeName, bool throwOnError);
        public static Type GetType(string typeName);
        public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver);
        public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError);
        public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase);
        public static Type GetTypeFromHandle(RuntimeTypeHandle handle);
        public Type GetType();
        protected abstract bool IsArrayImpl();
        protected abstract bool IsByRefImpl();
        protected abstract bool IsPointerImpl();
        protected abstract bool HasElementTypeImpl();
        public abstract Type GetElementType();
        public virtual int GetArrayRank();
        public virtual Type GetGenericTypeDefinition();
        public virtual Type[] GetGenericArguments();
        public virtual Type[] GetOptionalCustomModifiers();
        public virtual Type[] GetRequiredCustomModifiers();
        public virtual Type[] GetGenericParameterConstraints();
        protected abstract TypeAttributes GetAttributeFlagsImpl();
        protected abstract bool IsCOMObjectImpl();
        protected virtual bool IsContextfulImpl();
        protected virtual bool IsMarshalByRefImpl();
        protected abstract bool IsPrimitiveImpl();
        protected virtual bool IsValueTypeImpl();
        public bool IsAssignableTo(Type targetType);
        public ConstructorInfo GetConstructor(Type[] types);
        public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Type[] types);
        public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
        public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        public ConstructorInfo[] GetConstructors();
        public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
        public EventInfo GetEvent(string name);
        public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);
        public virtual EventInfo[] GetEvents();
        public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);
        public FieldInfo GetField(string name);
        public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);
        public FieldInfo[] GetFields();
        public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);
        public virtual Type[] GetFunctionPointerCallingConventions();
        public virtual Type GetFunctionPointerReturnType();
        public virtual Type[] GetFunctionPointerParameterTypes();
        public MemberInfo[] GetMember(string name);
        public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
        public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
        public MemberInfo[] GetMembers();
        public virtual MemberInfo GetMemberWithSameMetadataDefinitionAs(MemberInfo member);
        public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);
        public MethodInfo GetMethod(string name);
        public MethodInfo GetMethod(string name, BindingFlags bindingAttr);
        public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Type[] types);
        public MethodInfo GetMethod(string name, Type[] types);
        public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types);
        public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo GetMethod(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo GetMethod(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        protected virtual MethodInfo GetMethodImpl(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo[] GetMethods();
        public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);
        public Type GetNestedType(string name);
        public abstract Type GetNestedType(string name, BindingFlags bindingAttr);
        public Type[] GetNestedTypes();
        public abstract Type[] GetNestedTypes(BindingFlags bindingAttr);
        public PropertyInfo GetProperty(string name);
        public PropertyInfo GetProperty(string name, BindingFlags bindingAttr);
        public PropertyInfo GetProperty(string name, Type returnType);
        public PropertyInfo GetProperty(string name, Type[] types);
        public PropertyInfo GetProperty(string name, Type returnType, Type[] types);
        public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers);
        public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
        protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
        public PropertyInfo[] GetProperties();
        public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);
        public virtual MemberInfo[] GetDefaultMembers();
        public static RuntimeTypeHandle GetTypeHandle(object o);
        public static Type[] GetTypeArray(object[] args);
        public static TypeCode GetTypeCode(Type type);
        protected virtual TypeCode GetTypeCodeImpl();
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromCLSID(Guid clsid);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromCLSID(Guid clsid, bool throwOnError);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromCLSID(Guid clsid, string server);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromProgID(string progID);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromProgID(string progID, bool throwOnError);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromProgID(string progID, string server);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromProgID(string progID, string server, bool throwOnError);
        public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args);
        public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture);
        public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
        public Type GetInterface(string name);
        public abstract Type GetInterface(string name, bool ignoreCase);
        public abstract Type[] GetInterfaces();
        public virtual InterfaceMapping GetInterfaceMap(Type interfaceType);
        public virtual bool IsInstanceOfType(object o);
        public virtual bool IsEquivalentTo(Type other);
        public virtual Type GetEnumUnderlyingType();
        public virtual Array GetEnumValues();
        public virtual Array GetEnumValuesAsUnderlyingType();
        public virtual Type MakeArrayType();
        public virtual Type MakeArrayType(int rank);
        public virtual Type MakeByRefType();
        public virtual Type MakeGenericType(params Type[] typeArguments);
        public virtual Type MakePointerType();
        public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments);
        public static Type MakeGenericMethodParameter(int position);
        public override string ToString();
        public override bool Equals(object o);
        public override int GetHashCode();
        public virtual bool Equals(Type o);
        [Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static Type ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase);
        public virtual bool IsEnumDefined(object value);
        public virtual string GetEnumName(object value);
        public virtual string[] GetEnumNames();
        public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria);
        public virtual MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria);
        public virtual bool IsSubclassOf(Type c);
        public virtual bool IsAssignableFrom(Type c);

        public static bool operator ==(Type left, Type right);
        public static bool operator !=(Type left, Type right);
    }
}
