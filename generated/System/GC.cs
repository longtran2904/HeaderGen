#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System
{
    public static class GC
    {
        public static int MaxGeneration { get; }

        public static GCMemoryInfo GetGCMemoryInfo();
        public static GCMemoryInfo GetGCMemoryInfo(GCKind kind);
        public static void AddMemoryPressure(long bytesAllocated);
        public static void RemoveMemoryPressure(long bytesAllocated);
        public static int GetGeneration(object obj);
        public static void Collect(int generation);
        public static void Collect();
        public static void Collect(int generation, GCCollectionMode mode);
        public static void Collect(int generation, GCCollectionMode mode, bool blocking);
        public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting);
        public static int CollectionCount(int generation);
        public static void KeepAlive(object obj);
        public static int GetGeneration(WeakReference wo);
        public static void WaitForPendingFinalizers();
        public static void SuppressFinalize(object obj);
        public static void ReRegisterForFinalize(object obj);
        public static long GetTotalMemory(bool forceFullCollection);
        public static long GetAllocatedBytesForCurrentThread();
        public static long GetTotalAllocatedBytes(bool precise = False);
        public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold);
        public static void CancelFullGCNotification();
        public static GCNotificationStatus WaitForFullGCApproach();
        public static GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout);
        public static GCNotificationStatus WaitForFullGCComplete();
        public static GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout);
        public static bool TryStartNoGCRegion(long totalSize);
        public static bool TryStartNoGCRegion(long totalSize, long lohSize);
        public static bool TryStartNoGCRegion(long totalSize, bool disallowFullBlockingGC);
        public static bool TryStartNoGCRegion(long totalSize, long lohSize, bool disallowFullBlockingGC);
        public static void EndNoGCRegion();
        public static void RegisterNoGCRegionCallback(long totalSize, Action callback);
        public static T[] AllocateUninitializedArray<T>(int length, bool pinned = False);
        public static T[] AllocateArray<T>(int length, bool pinned = False);
        public static TimeSpan GetTotalPauseDuration();
        public static IReadOnlyDictionary<string, object> GetConfigurationVariables();
        public static void RefreshMemoryLimit();
        public static GCNotificationStatus WaitForFullGCApproach(TimeSpan timeout);
        public static GCNotificationStatus WaitForFullGCComplete(TimeSpan timeout);
    }
}
