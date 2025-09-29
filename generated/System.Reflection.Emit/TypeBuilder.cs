#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
    public abstract class TypeBuilder : TypeInfo
    {

        public const int UnspecifiedTypeSize = 0;

        protected TypeBuilder();

        public PackingSize PackingSize { get; }
        protected abstract PackingSize PackingSizeCore { get; }
        public int Size { get; }
        protected abstract int SizeCore { get; }

        public static MethodInfo GetMethod(Type type, MethodInfo method);
        public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor);
        public static FieldInfo GetField(Type type, FieldInfo field);
        public void AddInterfaceImplementation(Type interfaceType);
        protected abstract void AddInterfaceImplementationCore(Type interfaceType);
        public Type CreateType();
        public TypeInfo CreateTypeInfo();
        protected abstract TypeInfo CreateTypeInfoCore();
        public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes);
        public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers);
        protected abstract ConstructorBuilder DefineConstructorCore(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers);
        public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes);
        protected abstract ConstructorBuilder DefineDefaultConstructorCore(MethodAttributes attributes);
        public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype);
        protected abstract EventBuilder DefineEventCore(string name, EventAttributes attributes, Type eventtype);
        public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes);
        public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes);
        protected abstract FieldBuilder DefineFieldCore(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes);
        public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names);
        protected abstract GenericTypeParameterBuilder[] DefineGenericParametersCore(params string[] names);
        public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes);
        protected abstract FieldBuilder DefineInitializedDataCore(string name, byte[] data, FieldAttributes attributes);
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes);
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention);
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes);
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
        protected abstract MethodBuilder DefineMethodCore(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
        public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration);
        protected abstract void DefineMethodOverrideCore(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration);
        public TypeBuilder DefineNestedType(string name);
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr);
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent);
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces);
        protected abstract TypeBuilder DefineNestedTypeCore(string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packSize, int typeSize);
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, int typeSize);
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize);
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize, int typeSize);
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet);
        protected abstract MethodBuilder DefinePInvokeMethodCore(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet);
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] parameterTypes);
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
        protected abstract PropertyBuilder DefinePropertyCore(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
        public ConstructorBuilder DefineTypeInitializer();
        protected abstract ConstructorBuilder DefineTypeInitializerCore();
        public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes);
        protected abstract FieldBuilder DefineUninitializedDataCore(string name, int size, FieldAttributes attributes);
        public bool IsCreated();
        protected abstract bool IsCreatedCore();
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public void SetParent(Type parent);
        protected abstract void SetParentCore(Type parent);
        public override Type MakePointerType();
        public override Type MakeByRefType();
        public override Type MakeArrayType();
        public override Type MakeArrayType(int rank);
        public override Type MakeGenericType(params Type[] typeArguments);
    }
}
