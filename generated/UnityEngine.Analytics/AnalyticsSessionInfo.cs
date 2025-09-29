#region UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
    [NativeHeader("UnityAnalyticsScriptingClasses.h")]
    [NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
    [RequiredByNativeCode]
    public static class AnalyticsSessionInfo
    {
        public static AnalyticsSessionState sessionState { get; }
        public static long sessionId { get; }
        public static long sessionCount { get; }
        public static long sessionElapsedTime { get; }
        public static bool sessionFirstRun { get; }
        public static string userId { get; }
        public static string customUserId { get; set; }
        public static string customDeviceId { get; set; }
        public static string identityToken { get; }

        public static event SessionStateChanged sessionStateChanged;
        public static event IdentityTokenChanged identityTokenChanged;

        public delegate void SessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
        public delegate void IdentityTokenChanged(string token);
    }
}
