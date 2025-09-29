#region UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
    [ExcludeFromDocs]
    [NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
    [NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
    [RequiredByNativeCode]
    public class ContinuousEvent
    {

        public ContinuousEvent();

        public static AnalyticsResult RegisterCollector<T>(string metricName, Func<T> del) where T : IComparable<T>, IEquatable<T>, struct;
        public static AnalyticsResult SetEventHistogramThresholds<T>(string eventName, int count, T[] data, int ver = 1, string prefix = "") where T : IComparable<T>, IEquatable<T>, struct;
        public static AnalyticsResult SetCustomEventHistogramThresholds<T>(string eventName, int count, T[] data) where T : IComparable<T>, IEquatable<T>, struct;
        public static AnalyticsResult ConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled = True);
        public static AnalyticsResult ConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled = True, int ver = 1, string prefix = "");
    }
}
