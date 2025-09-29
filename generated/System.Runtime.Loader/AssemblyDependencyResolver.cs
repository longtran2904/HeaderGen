#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;
using System.Runtime.Versioning;

namespace System.Runtime.Loader
{
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public sealed class AssemblyDependencyResolver
    {
        public AssemblyDependencyResolver(string componentAssemblyPath);

        public string ResolveAssemblyToPath(AssemblyName assemblyName);
        public string ResolveUnmanagedDllToPath(string unmanagedDllName);
    }
}
