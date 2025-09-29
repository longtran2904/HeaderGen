#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class iPhoneSettings
    {
        public iPhoneSettings();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("screenOrientation property is deprecated. Please use Screen.orientation instead (UnityUpgradable) -> Screen.orientation", True)]
        public static iPhoneScreenOrientation screenOrientation { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("uniqueIdentifier property is deprecated. Please use SystemInfo.deviceUniqueIdentifier instead (UnityUpgradable) -> SystemInfo.deviceUniqueIdentifier", True)]
        public static string uniqueIdentifier { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("name property is deprecated (UnityUpgradable). Please use SystemInfo.deviceName instead (UnityUpgradable) -> SystemInfo.deviceName", True)]
        public static string name { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("model property is deprecated. Please use SystemInfo.deviceModel instead (UnityUpgradable) -> SystemInfo.deviceModel", True)]
        public static string model { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("systemName property is deprecated. Please use SystemInfo.operatingSystem instead (UnityUpgradable) -> SystemInfo.operatingSystem", True)]
        public static string systemName { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("internetReachability property is deprecated. Please use Application.internetReachability instead (UnityUpgradable) -> Application.internetReachability", True)]
        public static iPhoneNetworkReachability internetReachability { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("systemVersion property is deprecated. Please use iOS.Device.systemVersion instead (UnityUpgradable) -> UnityEngine.iOS.Device.systemVersion", True)]
        public static string systemVersion { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("generation property is deprecated. Please use iOS.Device.generation instead (UnityUpgradable) -> UnityEngine.iOS.Device.generation", True)]
        public static iPhoneGeneration generation { get; }
        [Obsolete("verticalOrientation property is deprecated. Please use Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown instead.", False)]
        public static bool verticalOrientation { get; }
        [Obsolete("screenCanDarken property is deprecated. Please use (Screen.sleepTimeout != SleepTimeout.NeverSleep) instead.", False)]
        public static bool screenCanDarken { get; }
        [Obsolete("locationServiceEnabledByUser property is deprecated. Please use Input.location.isEnabledByUser instead.", True)]
        public static bool locationServiceEnabledByUser { get; }

        [Obsolete("StartLocationServiceUpdates method is deprecated. Please use Input.location.Start instead.", True)]
        public static void StartLocationServiceUpdates(float desiredAccuracyInMeters, float updateDistanceInMeters);
        [Obsolete("StartLocationServiceUpdates method is deprecated. Please use Input.location.Start instead.", True)]
        public static void StartLocationServiceUpdates(float desiredAccuracyInMeters);
        [Obsolete("StartLocationServiceUpdates method is deprecated. Please use Input.location.Start instead.", True)]
        public static void StartLocationServiceUpdates();
        [Obsolete("StopLocationServiceUpdates method is deprecated. Please use Input.location.Stop instead.", True)]
        public static void StopLocationServiceUpdates();
    }
}
