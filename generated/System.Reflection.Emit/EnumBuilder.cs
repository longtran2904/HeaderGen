#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class EnumBuilder : TypeInfo
    {

        protected EnumBuilder();

        public FieldBuilder UnderlyingField { get; }
        protected abstract FieldBuilder UnderlyingFieldCore { get; }

        public Type CreateType();
        public TypeInfo CreateTypeInfo();
        protected abstract TypeInfo CreateTypeInfoCore();
        public FieldBuilder DefineLiteral(string literalName, object literalValue);
        protected abstract FieldBuilder DefineLiteralCore(string literalName, object literalValue);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public override Type MakePointerType();
        public override Type MakeByRefType();
        public override Type MakeArrayType();
        public override Type MakeArrayType(int rank);
    }
}
