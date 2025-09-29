#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class EventBuilder
    {

        protected EventBuilder();

        public void AddOtherMethod(MethodBuilder mdBuilder);
        protected abstract void AddOtherMethodCore(MethodBuilder mdBuilder);
        public void SetAddOnMethod(MethodBuilder mdBuilder);
        protected abstract void SetAddOnMethodCore(MethodBuilder mdBuilder);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public void SetRaiseMethod(MethodBuilder mdBuilder);
        protected abstract void SetRaiseMethodCore(MethodBuilder mdBuilder);
        public void SetRemoveOnMethod(MethodBuilder mdBuilder);
        protected abstract void SetRemoveOnMethodCore(MethodBuilder mdBuilder);
    }
}
