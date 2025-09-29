#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Versioning;

namespace System
{
    public sealed class OperatingSystem : ICloneable, ISerializable
    {

        public OperatingSystem(PlatformID platform, Version version);

        public PlatformID Platform { get; }
        public string ServicePack { get; }
        public Version Version { get; }
        public string VersionString { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public object Clone();
        public override string ToString();
        public static bool IsOSPlatform(string platform);
        public static bool IsOSPlatformVersionAtLeast(string platform, int major, int minor = 0, int build = 0, int revision = 0);
        public static bool IsBrowser();
        public static bool IsWasi();
        public static bool IsLinux();
        public static bool IsFreeBSD();
        public static bool IsFreeBSDVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0);
        public static bool IsAndroid();
        public static bool IsAndroidVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0);
        [SupportedOSPlatformGuard("maccatalyst")]
        public static bool IsIOS();
        [SupportedOSPlatformGuard("maccatalyst")]
        public static bool IsIOSVersionAtLeast(int major, int minor = 0, int build = 0);
        public static bool IsMacOS();
        public static bool IsMacOSVersionAtLeast(int major, int minor = 0, int build = 0);
        public static bool IsMacCatalyst();
        public static bool IsMacCatalystVersionAtLeast(int major, int minor = 0, int build = 0);
        public static bool IsTvOS();
        public static bool IsTvOSVersionAtLeast(int major, int minor = 0, int build = 0);
        public static bool IsWatchOS();
        public static bool IsWatchOSVersionAtLeast(int major, int minor = 0, int build = 0);
        public static bool IsWindows();
        public static bool IsWindowsVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0);
    }
}
