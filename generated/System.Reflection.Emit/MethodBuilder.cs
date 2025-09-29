#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class MethodBuilder : MethodInfo
    {

        protected MethodBuilder();

        public bool InitLocals { get; set; }
        protected abstract bool InitLocalsCore { get; set; }

        public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names);
        protected abstract GenericTypeParameterBuilder[] DefineGenericParametersCore(params string[] names);
        public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName);
        protected abstract ParameterBuilder DefineParameterCore(int position, ParameterAttributes attributes, string strParamName);
        public ILGenerator GetILGenerator();
        public ILGenerator GetILGenerator(int size);
        protected abstract ILGenerator GetILGeneratorCore(int size);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public void SetImplementationFlags(MethodImplAttributes attributes);
        protected abstract void SetImplementationFlagsCore(MethodImplAttributes attributes);
        public void SetParameters(params Type[] parameterTypes);
        public void SetReturnType(Type returnType);
        public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
        protected abstract void SetSignatureCore(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
    }
}
