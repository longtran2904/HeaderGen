#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public static class RuntimeInformation
    {
        public static string FrameworkDescription { get; }
        public static string RuntimeIdentifier { get; }
        public static Architecture ProcessArchitecture { get; }
        public static string OSDescription { get; }
        public static Architecture OSArchitecture { get; }

        public static bool IsOSPlatform(OSPlatform osPlatform);
    }
}
