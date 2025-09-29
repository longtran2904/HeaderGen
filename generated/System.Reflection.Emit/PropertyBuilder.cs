#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class PropertyBuilder : PropertyInfo
    {
        protected PropertyBuilder();

        public void AddOtherMethod(MethodBuilder mdBuilder);
        protected abstract void AddOtherMethodCore(MethodBuilder mdBuilder);
        public void SetConstant(object defaultValue);
        protected abstract void SetConstantCore(object defaultValue);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public void SetGetMethod(MethodBuilder mdBuilder);
        protected abstract void SetGetMethodCore(MethodBuilder mdBuilder);
        public void SetSetMethod(MethodBuilder mdBuilder);
        protected abstract void SetSetMethodCore(MethodBuilder mdBuilder);
    }
}
