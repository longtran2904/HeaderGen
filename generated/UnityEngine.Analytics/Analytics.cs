#region UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
    [NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
    [NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
    [NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
    public static class Analytics
    {

        public static bool initializeOnStartup { get; set; }
        public static bool playerOptedOut { get; }
        public static string eventUrl { get; }
        public static string dashboardUrl { get; }
        public static string configUrl { get; }
        public static bool limitUserTracking { get; set; }
        public static bool deviceStatsEnabled { get; set; }
        public static bool enabled { get; set; }

        public static AnalyticsResult ResumeInitialization();
        public static AnalyticsResult FlushEvents();
        [Obsolete("SetUserId is no longer supported", True)]
        public static AnalyticsResult SetUserId(string userId);
        [Obsolete("SetUserGender is no longer supported", True)]
        public static AnalyticsResult SetUserGender(Gender gender);
        [Obsolete("SetUserBirthYear is no longer supported", True)]
        public static AnalyticsResult SetUserBirthYear(int birthYear);
        public static AnalyticsResult Transaction(string productId, decimal amount, string currency);
        public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
        public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
        public static AnalyticsResult CustomEvent(string customEventName);
        public static AnalyticsResult CustomEvent(string customEventName, Vector3 position);
        public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData);
        public static AnalyticsResult EnableCustomEvent(string customEventName, bool enabled);
        public static AnalyticsResult IsCustomEventEnabled(string customEventName);
        public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey = "", string prefix = "");
        public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix = "");
        public static AnalyticsResult SendEvent(string eventName, object parameters, int ver = 1, string prefix = "");
        public static AnalyticsResult SetEventEndPoint(string eventName, string endPoint, int ver = 1, string prefix = "");
        public static AnalyticsResult SetEventPriority(string eventName, AnalyticsEventPriority eventPriority, int ver = 1, string prefix = "");
        public static AnalyticsResult EnableEvent(string eventName, bool enabled, int ver = 1, string prefix = "");
        public static AnalyticsResult IsEventEnabled(string eventName, int ver = 1, string prefix = "");
    }
}
