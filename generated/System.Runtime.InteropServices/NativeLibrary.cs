#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Runtime.InteropServices
{
    public static class NativeLibrary
    {

        public static nint Load(string libraryPath);
        public static bool TryLoad(string libraryPath, out nint handle);
        public static nint Load(string libraryName, Assembly assembly, DllImportSearchPath? searchPath);
        public static bool TryLoad(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out nint handle);
        public static void Free(nint handle);
        public static nint GetExport(nint handle, string name);
        public static bool TryGetExport(nint handle, string name, out nint address);
        public static void SetDllImportResolver(Assembly assembly, DllImportResolver resolver);
        public static nint GetMainProgramHandle();
    }
}
