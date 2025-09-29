#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Analytics
{
    [NativeHeader("Modules/UnityConnect/UnityAnalytics/UnityAnalyticsSettings.h")]
    [NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
    [StaticAccessor("GetUnityAnalyticsSettings()", StaticAccessorType.Dot)]
    public static class AnalyticsSettings
    {
        public static bool enabled { get; set; }
        public static bool testMode { get; set; }
        public static bool initializeOnStartup { get; set; }
        public static bool deviceStatsEnabledInBuild { get; }
        public static bool packageRequiringCoreStatsPresent { get; set; }
        [StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
        public static string eventUrl { get; set; }
        [StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
        public static string configUrl { get; set; }
        [StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
        public static string dashboardUrl { get; set; }

        public static event RequireInBuildDelegate OnRequireInBuildHandler;

        public delegate bool RequireInBuildDelegate();
    }
}
