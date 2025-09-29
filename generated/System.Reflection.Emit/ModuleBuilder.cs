#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
    public abstract class ModuleBuilder : Module
    {
        protected ModuleBuilder();

        public void CreateGlobalFunctions();
        protected abstract void CreateGlobalFunctionsCore();
        public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType);
        protected abstract EnumBuilder DefineEnumCore(string name, TypeAttributes visibility, Type underlyingType);
        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes);
        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
        protected abstract MethodBuilder DefineGlobalMethodCore(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
        public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes);
        protected abstract FieldBuilder DefineInitializedDataCore(string name, byte[] data, FieldAttributes attributes);
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
        protected abstract MethodBuilder DefinePInvokeMethodCore(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
        public TypeBuilder DefineType(string name);
        public TypeBuilder DefineType(string name, TypeAttributes attr);
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent);
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces);
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, int typesize);
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packsize);
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packingSize, int typesize);
        protected abstract TypeBuilder DefineTypeCore(string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packingSize, int typesize);
        public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes);
        protected abstract FieldBuilder DefineUninitializedDataCore(string name, int size, FieldAttributes attributes);
        public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
        protected abstract MethodInfo GetArrayMethodCore(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public abstract int GetTypeMetadataToken(Type type);
        public abstract int GetFieldMetadataToken(FieldInfo field);
        public abstract int GetMethodMetadataToken(MethodInfo method);
        public abstract int GetMethodMetadataToken(ConstructorInfo constructor);
        public abstract int GetSignatureMetadataToken(SignatureHelper signature);
        public abstract int GetStringMetadataToken(string stringConstant);
    }
}
