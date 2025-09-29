#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.iOS
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
        public static bool hideHomeButton { get; set; }
        public static bool lowPowerModeEnabled { get; }
        public static bool wantsSoftwareDimming { get; set; }
        public static bool iosAppOnMac { get; }
        public static SystemGestureDeferMode deferSystemGesturesMode { get; set; }

        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        [NativeMethod(Name = "IOSScripting::SetNoBackupFlag", IsThreadSafe = True, IsFreeFunction = True)]
        public static void SetNoBackupFlag(string path);
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        [NativeMethod(Name = "IOSScripting::ResetNoBackupFlag", IsThreadSafe = True, IsFreeFunction = True)]
        public static void ResetNoBackupFlag(string path);
        [NativeConditional("PLATFORM_IOS")]
        [NativeMethod(Name = "IOSScripting::RequestStoreReview", IsThreadSafe = True, IsFreeFunction = True)]
        public static bool RequestStoreReview();
    }
}
