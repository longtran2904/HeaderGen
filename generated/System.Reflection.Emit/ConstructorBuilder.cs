#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class ConstructorBuilder : ConstructorInfo
    {

        protected ConstructorBuilder();

        public bool InitLocals { get; set; }
        protected abstract bool InitLocalsCore { get; set; }

        public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName);
        protected abstract ParameterBuilder DefineParameterCore(int iSequence, ParameterAttributes attributes, string strParamName);
        public ILGenerator GetILGenerator();
        public ILGenerator GetILGenerator(int streamSize);
        protected abstract ILGenerator GetILGeneratorCore(int streamSize);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public void SetImplementationFlags(MethodImplAttributes attributes);
        protected abstract void SetImplementationFlagsCore(MethodImplAttributes attributes);
    }
}
