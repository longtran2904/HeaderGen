#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
    [NativeConditional("ENABLE_PROFILER")]
    public static class AsyncReadManagerMetrics
    {
        [FreeFunction("AreMetricsEnabled_Internal")]
        public static bool IsEnabled();
        public static void ClearCompletedMetrics();
        public static AsyncReadManagerRequestMetric[] GetMetrics(AsyncReadManagerMetricsFilters filters, Flags flags);
        public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetricsFilters filters, Flags flags);
        public static AsyncReadManagerRequestMetric[] GetMetrics(Flags flags);
        public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, Flags flags);
        [FreeFunction("GetAsyncReadManagerMetrics()->StartCollecting")]
        public static void StartCollectingMetrics();
        [FreeFunction("GetAsyncReadManagerMetrics()->StopCollecting")]
        public static void StopCollectingMetrics();
        public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(Flags flags);
        public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetricsFilters metricsFilters, Flags flags);
        public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(AsyncReadManagerRequestMetric[] metrics);
        public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics);
        public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(AsyncReadManagerRequestMetric[] metrics, AsyncReadManagerMetricsFilters metricsFilters);
        public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters);
        [FreeFunction("GetAsyncReadManagerMetrics()->GetTotalSizeNonASRMReadsBytes")]
        [ThreadSafe]
        public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead);

        [Flags]
        public enum Flags
        {
            None = 0,
            ClearOnRead = 1
        }
    }
}
