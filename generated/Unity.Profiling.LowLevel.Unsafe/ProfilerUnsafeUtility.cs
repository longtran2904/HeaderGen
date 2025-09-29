#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
    [NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
    [UsedByNativeCode]
    public static class ProfilerUnsafeUtility
    {

        public const ushort CategoryRender = 0;
        public const ushort CategoryScripts = 1;
        public const ushort CategoryGUI = 4;
        public const ushort CategoryPhysics = 5;
        public const ushort CategoryAnimation = 6;
        public const ushort CategoryAi = 7;
        public const ushort CategoryAudio = 8;
        public const ushort CategoryVideo = 11;
        public const ushort CategoryParticles = 12;
        public const ushort CategoryLighting = 13;
        [Obsolete("CategoryLightning has been renamed. Use CategoryLighting instead (UnityUpgradable) -> CategoryLighting", False)]
        public const ushort CategoryLightning = 13;
        public const ushort CategoryNetwork = 14;
        public const ushort CategoryLoading = 15;
        public const ushort CategoryOther = 16;
        public const ushort CategoryVr = 22;
        public const ushort CategoryAllocation = 23;
        public const ushort CategoryInternal = 24;
        public const ushort CategoryFileIO = 25;
        public const ushort CategoryInput = 30;
        public const ushort CategoryVirtualTexturing = 31;

        public static long Timestamp { get; }
        public static TimestampConversionRatio TimestampToNanosecondsConversionRatio { get; }

        public static ushort CreateCategory(char* name, int nameLen, ProfilerCategoryColor colorIndex);
        public static ushort GetCategoryByName(char* name, int nameLen);
        [ThreadSafe]
        public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId);
        [ThreadSafe]
        public static nint CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount);
        public static nint CreateMarker(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount);
        [ThreadSafe]
        public static void SetMarkerMetadata(nint markerPtr, int index, string name, byte type, byte unit);
        public static void SetMarkerMetadata(nint markerPtr, int index, char* name, int nameLen, byte type, byte unit);
        [ThreadSafe]
        public static void BeginSample(nint markerPtr);
        [ThreadSafe]
        public static void BeginSampleWithMetadata(nint markerPtr, int metadataCount, void* metadata);
        [ThreadSafe]
        public static void EndSample(nint markerPtr);
        [ThreadSafe]
        public static void SingleSampleWithMetadata(nint markerPtr, int metadataCount, void* metadata);
        [ThreadSafe]
        public static void* CreateCounterValue(out nint counterPtr, string name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);
        public static void* CreateCounterValue(out nint counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);
        [ThreadSafe]
        public static void FlushCounterValue(void* counterValuePtr);
        [ThreadSafe]
        public static uint CreateFlow(ushort categoryId);
        [ThreadSafe]
        public static void FlowEvent(uint flowId, ProfilerFlowEventType flowEventType);
        public struct TimestampConversionRatio
        {

            public long Numerator;
            public long Denominator;
        }
    }
}
