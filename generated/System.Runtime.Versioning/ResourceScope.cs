#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Versioning
{
    [Flags]
    public enum ResourceScope
    {

        None = 0,
        Machine = 1,
        Process = 2,
        AppDomain = 4,
        Library = 8,
        Private = 16,
        Assembly = 32
    }
}
