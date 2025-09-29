#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class ParameterBuilder
    {

        protected ParameterBuilder();

        public virtual int Attributes { get; }
        public bool IsIn { get; }
        public bool IsOptional { get; }
        public bool IsOut { get; }
        public virtual string Name { get; }
        public virtual int Position { get; }

        public virtual void SetConstant(object defaultValue);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    }
}
