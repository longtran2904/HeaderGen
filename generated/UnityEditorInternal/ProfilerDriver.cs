#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Profiling;

namespace UnityEditorInternal
{
    [NativeHeader("Modules/Profiler/Instrumentation/InstrumentationProfiler.h")]
    [NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
    [NativeHeader("Modules/Profiler/Runtime/CollectProfilerStats.h")]
    [NativeHeader("Modules/ProfilerEditor/Public/EditorProfilerConnection.h")]
    [NativeHeader("Modules/ProfilerEditor/ProfilerHistory/ProfilerProperty.h")]
    [NativeHeader("Modules/ProfilerEditor/Public/ProfilerSession.h")]
    public static class ProfilerDriver
    {

        public static string directConnectionPort;

        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static int firstFrameIndex { get; }
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static int lastFrameIndex { get; }
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static string selectedPropertyPath { get; set; }
        public static bool enabled { get; set; }
        public static bool profileGPU { get; set; }
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static bool profileEditor { get; set; }
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static bool deepProfiling { get; set; }
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static ProfilerMemoryRecordMode memoryRecordMode { get; set; }
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static string directConnectionUrl { get; }
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static int connectedProfiler { get; set; }
        public static string miniMemoryOverview { get; }
        public static uint usedHeapSize { get; }
        public static uint objectCount { get; }
        [Obsolete("Deprecated, use GetGPUStatisticsAvailabilityState instead.")]
        public static bool isGPUProfilerSupportedByOS { get; }
        [Obsolete("Deprecated, use GetGPUStatisticsAvailabilityState instead.")]
        public static bool isGPUProfilerSupported { get; }
        [Obsolete("Deprecated API, it will always return false, use GetGPUStatisticsAvailabilityState instead.")]
        public static bool isGPUProfilerBuggyOnDriver { get; }

        public static event Action<int, int> NewProfilerFrameRecorded;
        public static event Action profileLoaded;
        public static event Action profileCleared;

        [NativeMethod("CleanupFrameHistory")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static void ClearAllFrames();
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static int GetNextFrameIndex(int frame);
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static int GetPreviousFrameIndex(int frame);
        [NativeMethod("SetProfileArea")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static void SetAreaEnabled(ProfilerArea area, bool enabled);
        [NativeMethod("IsProfilingArea")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static bool IsAreaEnabled(ProfilerArea area);
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static void SetMarkerFiltering(string name);
        [Obsolete("Use GetFormattedCounterValue to get the stats including Profiler Counter data", False)]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static string GetFormattedStatisticsValue(int frame, int identifier);
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static int GetUISystemEventMarkersCount(int firstFrame, int frameCount);
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static void GetUISystemEventMarkersBatch(int firstFrame, int frameCount, out EventMarker[] buffer, out string[] names);
        [NativeMethod("GetStatisticsValuesBatch")]
        [Obsolete("Use GetCounterValuesBatch to read the stats including Profiler Counter data", False)]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static void GetStatisticsValues(int identifier, int firstFrame, float scale, out float[] buffer, out float maxValue);
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static string GetFormattedCounterValue(int frame, ProfilerArea area, string name);
        public static string GetFormattedCounterValue(int frame, string category, string name);
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static void GetCounterValuesBatch(ProfilerArea area, string name, int firstFrame, float scale, out float[] buffer, out float maxValue);
        public static void GetCounterValuesBatch(string category, string name, int firstFrame, float scale, out float[] buffer, out float maxValue);
        public static void GetGpuStatisticsAvailabilityStates(int firstFrame, out GpuProfilingStatisticsAvailabilityStates[] buffer);
        [NativeMethod("GetGpuStatisticsAvailabilityState")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static GpuProfilingStatisticsAvailabilityStates GetGpuStatisticsAvailabilityState(int frame);
        public static HierarchyFrameDataView GetHierarchyFrameDataView(int frameIndex, int threadIndex, HierarchyFrameDataView.ViewModes viewMode, int sortColumn, bool sortAscending);
        public static RawFrameDataView GetRawFrameDataView(int frameIndex, int threadIndex);
        [Obsolete("ResetHistory is deprecated, use ClearAllFrames instead.")]
        public static void ResetHistory();
        [NativeMethod("SaveToFile")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static void SaveProfile(string filename);
        [NativeMethod("LoadFromFile")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()", StaticAccessorType.Arrow)]
        public static bool LoadProfile(string filename, bool keepExistingData);
        [NativeMethod("GetAllStatisticsProperties")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static string[] GetAllStatisticsProperties();
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static string[] GetGraphStatisticsPropertiesForArea(ProfilerArea area);
        [Obsolete("Use GetStatisticsIdentifierForArea that takes ProfilerArea as first argument", False)]
        public static int GetStatisticsIdentifier(string propertyName);
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static void GetStatisticsAvailable(ProfilerArea profilerArea, int firstFrame, out int[] buffer);
        [Obsolete("GetStatisticsAvailable with bool buffer is obsolete, use with int array instead. (x & 1) == 1 is the same as true")]
        public static void GetStatisticsAvailable(ProfilerArea profilerArea, int firstFrame, out bool[] buffer);
        [NativeMethod("GetStatisticsIdentifier")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static int GetStatisticsIdentifierForArea(ProfilerArea profilerArea, string propertyName);
        [NativeMethod("GetConnectionIdentification")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static string GetConnectionIdentifier(int guid);
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static bool IsIdentifierConnectable(int guid);
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void DirectIPConnect(string IP);
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void DirectURLConnect(string IP);
        [NativeMethod("GetAvailableProfilers")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static int[] GetAvailableProfilers();
        [NativeMethod("GetOverviewTextForProfilerArea")]
        [StaticAccessor("profiling::GetProfilerSessionPtr()->GetProfilerHistory()", StaticAccessorType.Arrow)]
        public static string GetOverviewText(ProfilerArea profilerArea, int frame);
        public static void RequestMemorySnapshot();
        [NativeMethod("SendGetObjectMemoryProfile")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void RequestObjectMemoryInfo(bool gatherObjectReferences);
        [NativeMethod("SendQueryInstrumentableFunctions")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void QueryInstrumentableFunctions();
        [NativeMethod("SendQueryFunctionCallees")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void QueryFunctionCallees(string fullname);
        [NativeMethod("SendSetAudioCaptureFlags")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void SetAudioCaptureFlags(int flags);
        [NativeMethod("SendBeginInstrumentFunction")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void BeginInstrumentFunction(string fullName);
        [NativeMethod("SendEndInstrumentFunction")]
        [StaticAccessor("EditorProfilerConnection::Get()", StaticAccessorType.Dot)]
        public static void EndInstrumentFunction(string fullName);
    }
}
