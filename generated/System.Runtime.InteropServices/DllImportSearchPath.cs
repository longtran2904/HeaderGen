#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [Flags]
    public enum DllImportSearchPath
    {
        UseDllDirectoryForDependencies = 256,
        ApplicationDirectory = 512,
        UserDirectories = 1024,
        System32 = 2048,
        SafeDirectories = 4096,
        AssemblyDirectory = 2,
        LegacyBehavior = 0
    }
}
