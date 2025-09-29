#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = False)]
    public sealed class RequiresDynamicCodeAttribute : Attribute
    {

        public RequiresDynamicCodeAttribute(string message);

        public string Message { get; }
        public string Url { get; set; }
    }
}
