#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.Reflection;

namespace System.Runtime.InteropServices
{
    public static class RuntimeEnvironment
    {

        [Obsolete("RuntimeEnvironment members SystemConfigurationFile, GetRuntimeInterfaceAsIntPtr, and GetRuntimeInterfaceAsObject are not supported and throw PlatformNotSupportedException.", DiagnosticId = "SYSLIB0019", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static string SystemConfigurationFile { get; }

        public static bool FromGlobalAccessCache(Assembly a);
        public static string GetRuntimeDirectory();
        [Obsolete("RuntimeEnvironment members SystemConfigurationFile, GetRuntimeInterfaceAsIntPtr, and GetRuntimeInterfaceAsObject are not supported and throw PlatformNotSupportedException.", DiagnosticId = "SYSLIB0019", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static nint GetRuntimeInterfaceAsIntPtr(Guid clsid, Guid riid);
        [Obsolete("RuntimeEnvironment members SystemConfigurationFile, GetRuntimeInterfaceAsIntPtr, and GetRuntimeInterfaceAsObject are not supported and throw PlatformNotSupportedException.", DiagnosticId = "SYSLIB0019", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static object GetRuntimeInterfaceAsObject(Guid clsid, Guid riid);
        public static string GetSystemVersion();
    }
}
