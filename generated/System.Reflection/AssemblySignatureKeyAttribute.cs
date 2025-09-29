#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = False, Inherited = False)]
    public sealed class AssemblySignatureKeyAttribute : Attribute
    {
        public AssemblySignatureKeyAttribute(string publicKey, string countersignature);

        public string PublicKey { get; }
        public string Countersignature { get; }
    }
}
