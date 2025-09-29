#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = False, Inherited = False)]
    [Obsolete("DisablePrivateReflectionAttribute has no effect in .NET 6.0+.", DiagnosticId = "SYSLIB0015", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public sealed class DisablePrivateReflectionAttribute : Attribute
    {
        public DisablePrivateReflectionAttribute();
    }
}
