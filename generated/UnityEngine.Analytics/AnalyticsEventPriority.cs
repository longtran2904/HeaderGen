#region UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll
#endregion

using System;

namespace UnityEngine.Analytics
{
    [Flags]
    public enum AnalyticsEventPriority
    {

        FlushQueueFlag = 1,
        CacheImmediatelyFlag = 2,
        AllowInStopModeFlag = 4,
        SendImmediateFlag = 8,
        NoCachingFlag = 16,
        NoRetryFlag = 32,
        NormalPriorityEvent = 0,
        NormalPriorityEvent_WithCaching = 2,
        NormalPriorityEvent_NoRetryNoCaching = 48,
        HighPriorityEvent = 1,
        HighPriorityEvent_InStopMode = 5,
        HighestPriorityEvent = 9,
        HighestPriorityEvent_NoRetryNoCaching = 49
    }
}
