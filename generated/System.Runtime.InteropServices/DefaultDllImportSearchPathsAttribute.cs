#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = False)]
    public sealed class DefaultDllImportSearchPathsAttribute : Attribute
    {

        public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths);

        public DllImportSearchPath Paths { get; }
    }
}
