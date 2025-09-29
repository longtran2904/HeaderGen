#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Reflection
{
    public class TypeDelegator : TypeInfo
    {
        protected Type typeImpl;

        protected TypeDelegator();
        public TypeDelegator(Type delegatingType);

        public override Guid GUID { get; }
        public override int MetadataToken { get; }
        public override Module Module { get; }
        public override Assembly Assembly { get; }
        public override RuntimeTypeHandle TypeHandle { get; }
        public override string Name { get; }
        public override string FullName { get; }
        public override string Namespace { get; }
        public override string AssemblyQualifiedName { get; }
        public override Type BaseType { get; }
        public override bool IsTypeDefinition { get; }
        public override bool IsSZArray { get; }
        public override bool IsVariableBoundArray { get; }
        public override bool IsGenericTypeParameter { get; }
        public override bool IsGenericMethodParameter { get; }
        public override bool IsByRefLike { get; }
        public override bool IsConstructedGenericType { get; }
        public override bool IsCollectible { get; }
        public override bool IsFunctionPointer { get; }
        public override bool IsUnmanagedFunctionPointer { get; }
        public override Type UnderlyingSystemType { get; }

        public override bool IsAssignableFrom(TypeInfo typeInfo);
        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        public override MethodInfo[] GetMethods(BindingFlags bindingAttr);
        public override FieldInfo GetField(string name, BindingFlags bindingAttr);
        public override FieldInfo[] GetFields(BindingFlags bindingAttr);
        public override Type[] GetFunctionPointerCallingConventions();
        public override Type[] GetFunctionPointerParameterTypes();
        public override Type GetFunctionPointerReturnType();
        public override Type GetInterface(string name, bool ignoreCase);
        public override Type[] GetInterfaces();
        public override EventInfo GetEvent(string name, BindingFlags bindingAttr);
        public override EventInfo[] GetEvents();
        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr);
        public override EventInfo[] GetEvents(BindingFlags bindingAttr);
        public override Type[] GetNestedTypes(BindingFlags bindingAttr);
        public override Type GetNestedType(string name, BindingFlags bindingAttr);
        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
        public override MemberInfo GetMemberWithSameMetadataDefinitionAs(MemberInfo member);
        protected override TypeAttributes GetAttributeFlagsImpl();
        protected override bool IsArrayImpl();
        protected override bool IsPrimitiveImpl();
        protected override bool IsByRefImpl();
        protected override bool IsPointerImpl();
        protected override bool IsValueTypeImpl();
        protected override bool IsCOMObjectImpl();
        public override Type GetElementType();
        protected override bool HasElementTypeImpl();
        public override object[] GetCustomAttributes(bool inherit);
        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
        public override bool IsDefined(Type attributeType, bool inherit);
        public override InterfaceMapping GetInterfaceMap(Type interfaceType);
    }
}
