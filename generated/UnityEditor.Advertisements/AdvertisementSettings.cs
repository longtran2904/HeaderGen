#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Advertisements
{
    [NativeHeader("Modules/UnityConnect/UnityAds/UnityAdsSettings.h")]
    [StaticAccessor("GetUnityAdsSettings()", StaticAccessorType.Dot)]
    public static class AdvertisementSettings
    {

        public static bool enabled { get; set; }
        public static bool testMode { get; set; }
        public static bool initializeOnStartup { get; set; }

        public static string GetGameId(RuntimePlatform platform);
        public static void SetGameId(RuntimePlatform platform, string gameId);
        [Obsolete("No longer supported and will always return true")]
        public static bool IsPlatformEnabled(RuntimePlatform platform);
        [Obsolete("No longer supported and will do nothing")]
        public static void SetPlatformEnabled(RuntimePlatform platform, bool value);
        [NativeMethod("GetGameId")]
        public static string GetPlatformGameId(string platformName);
        [NativeMethod("SetGameId")]
        public static void SetPlatformGameId(string platformName, string gameId);
    }
}
