#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.ConstrainedExecution
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = False)]
    [Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public sealed class PrePrepareMethodAttribute : Attribute
    {

        public PrePrepareMethodAttribute();
    }
}
