#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
    [MovedFrom("UnityEngine")]
    [NativeHeader("Runtime/Allocator/MemoryManager.h")]
    [NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
    [NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
    [NativeHeader("Runtime/Profiler/Profiler.h")]
    [NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
    [UsedByNativeCode]
    public sealed class Profiler
    {

        public static bool supported { get; }
        [StaticAccessor("ProfilerBindings", StaticAccessorType.DoubleColon)]
        public static string logFile { get; set; }
        public static bool enableBinaryLog { get; set; }
        public static int maxUsedMemory { get; set; }
        public static bool enabled { get; set; }
        public static bool enableAllocationCallstacks { get; set; }
        public static int areaCount { get; }
        [Obsolete("maxNumberOfSamplesPerFrame has been depricated. Use maxUsedMemory instead")]
        public static int maxNumberOfSamplesPerFrame { get; set; }
        [Obsolete("usedHeapSize has been deprecated since it is limited to 4GB. Please use usedHeapSizeLong instead.")]
        public static uint usedHeapSize { get; }
        public static long usedHeapSizeLong { get; }

        [Conditional("ENABLE_PROFILER")]
        [FreeFunction("ProfilerBindings::profiler_set_area_enabled")]
        public static void SetAreaEnabled(ProfilerArea area, bool enabled);
        [FreeFunction("ProfilerBindings::profiler_is_area_enabled")]
        [NativeConditional("ENABLE_PROFILER")]
        public static bool GetAreaEnabled(ProfilerArea area);
        [Conditional("UNITY_EDITOR")]
        public static void AddFramesFromFile(string file);
        [Conditional("ENABLE_PROFILER")]
        public static void BeginThreadProfiling(string threadGroupName, string threadName);
        [NativeConditional("ENABLE_PROFILER")]
        public static void EndThreadProfiling();
        [Conditional("ENABLE_PROFILER")]
        public static void BeginSample(string name);
        [Conditional("ENABLE_PROFILER")]
        public static void BeginSample(string name, Object targetObject);
        [Conditional("ENABLE_PROFILER")]
        [NativeMethod(Name = "ProfilerBindings::EndSample", IsThreadSafe = True, IsFreeFunction = True)]
        public static void EndSample();
        [Obsolete("GetRuntimeMemorySize has been deprecated since it is limited to 2GB. Please use GetRuntimeMemorySizeLong() instead.")]
        public static int GetRuntimeMemorySize(Object o);
        [NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = True)]
        public static long GetRuntimeMemorySizeLong([NotNull("ArgumentNullException")] Object o);
        [Obsolete("GetMonoHeapSize has been deprecated since it is limited to 4GB. Please use GetMonoHeapSizeLong() instead.")]
        public static uint GetMonoHeapSize();
        [NativeMethod(Name = "scripting_gc_get_heap_size", IsFreeFunction = True)]
        public static long GetMonoHeapSizeLong();
        [Obsolete("GetMonoUsedSize has been deprecated since it is limited to 4GB. Please use GetMonoUsedSizeLong() instead.")]
        public static uint GetMonoUsedSize();
        [NativeMethod(Name = "scripting_gc_get_used_size", IsFreeFunction = True)]
        public static long GetMonoUsedSizeLong();
        [NativeConditional("ENABLE_MEMORY_MANAGER")]
        [StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
        public static bool SetTempAllocatorRequestedSize(uint size);
        [NativeConditional("ENABLE_MEMORY_MANAGER")]
        [StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
        public static uint GetTempAllocatorSize();
        [Obsolete("GetTotalAllocatedMemory has been deprecated since it is limited to 4GB. Please use GetTotalAllocatedMemoryLong() instead.")]
        public static uint GetTotalAllocatedMemory();
        [NativeConditional("ENABLE_MEMORY_MANAGER")]
        [NativeMethod(Name = "GetTotalAllocatedMemory")]
        [StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
        public static long GetTotalAllocatedMemoryLong();
        [Obsolete("GetTotalUnusedReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalUnusedReservedMemoryLong() instead.")]
        public static uint GetTotalUnusedReservedMemory();
        [NativeConditional("ENABLE_MEMORY_MANAGER")]
        [NativeMethod(Name = "GetTotalUnusedReservedMemory")]
        [StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
        public static long GetTotalUnusedReservedMemoryLong();
        [Obsolete("GetTotalReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalReservedMemoryLong() instead.")]
        public static uint GetTotalReservedMemory();
        [NativeConditional("ENABLE_MEMORY_MANAGER")]
        [NativeMethod(Name = "GetTotalReservedMemory")]
        [StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
        public static long GetTotalReservedMemoryLong();
        [NativeConditional("ENABLE_MEMORY_MANAGER")]
        public static long GetTotalFragmentationInfo(NativeArray<int> stats);
        [NativeConditional("ENABLE_PROFILER")]
        [NativeMethod(Name = "GetRegisteredGFXDriverMemory")]
        [StaticAccessor("GetMemoryManager()", StaticAccessorType.Dot)]
        public static long GetAllocatedMemoryForGraphicsDriver();
        [Conditional("ENABLE_PROFILER")]
        public static void EmitFrameMetaData(Guid id, int tag, Array data);
        [Conditional("ENABLE_PROFILER")]
        public static void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct;
        [Conditional("ENABLE_PROFILER")]
        public static void EmitFrameMetaData<T>(Guid id, int tag, NativeArray<T> data) where T : struct;
        [Conditional("ENABLE_PROFILER")]
        public static void EmitSessionMetaData(Guid id, int tag, Array data);
        [Conditional("ENABLE_PROFILER")]
        public static void EmitSessionMetaData<T>(Guid id, int tag, List<T> data) where T : struct;
        [Conditional("ENABLE_PROFILER")]
        public static void EmitSessionMetaData<T>(Guid id, int tag, NativeArray<T> data) where T : struct;
        [Conditional("ENABLE_PROFILER")]
        public static void SetCategoryEnabled(ProfilerCategory category, bool enabled);
        public static bool IsCategoryEnabled(ProfilerCategory category);
        [NativeConditional("ENABLE_PROFILER")]
        [NativeHeader("Runtime/Profiler/ProfilerManager.h")]
        [NativeMethod(Name = "GetCategoriesCount")]
        [StaticAccessor("profiling::GetProfilerManagerPtr()", StaticAccessorType.Arrow)]
        public static uint GetCategoriesCount();
        [Conditional("ENABLE_PROFILER")]
        public static void GetAllCategories(ProfilerCategory[] categories);
        [Conditional("ENABLE_PROFILER")]
        public static void GetAllCategories(NativeArray<ProfilerCategory> categories);
    }
}
