#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.tvOS
{
    [NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
    public sealed class Device
    {
        public Device();

        public static string systemVersion { get; }
        public static DeviceGeneration generation { get; }
        public static string vendorIdentifier { get; }
        public static string advertisingIdentifier { get; }
        public static bool advertisingTrackingEnabled { get; }

        public static void SetNoBackupFlag(string path);
        public static void ResetNoBackupFlag(string path);
    }
}
