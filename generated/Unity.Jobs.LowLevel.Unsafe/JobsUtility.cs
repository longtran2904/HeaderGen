#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Diagnostics;
using UnityEngine.Bindings;

namespace Unity.Jobs.LowLevel.Unsafe
{
    [NativeHeader("Runtime/Jobs/JobSystem.h")]
    [NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
    public static class JobsUtility
    {

        public const int MaxJobThreadCount = 128;
        public const int CacheLineSize = 64;

        public static bool IsExecutingJob { get; }
        public static bool JobDebuggerEnabled { get; set; }
        public static bool JobCompilerEnabled { get; set; }
        public static int JobWorkerMaximumCount { get; }
        public static int JobWorkerCount { get; set; }

        public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex);
        [NativeMethod(IsThreadSafe = True, IsFreeFunction = True)]
        public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex);
        [FreeFunction("ScheduleManagedJob", IsThreadSafe = True, ThrowsException = True)]
        public static JobHandle Schedule(ref JobScheduleParameters parameters);
        [FreeFunction("ScheduleManagedJobParallelFor", IsThreadSafe = True, ThrowsException = True)]
        public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount);
        [FreeFunction("ScheduleManagedJobParallelForDeferArraySize", IsThreadSafe = True, ThrowsException = True)]
        public static JobHandle ScheduleParallelForDeferArraySize(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle);
        [FreeFunction("ScheduleManagedJobParallelForTransform", ThrowsException = True)]
        public static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, nint transfromAccesssArray);
        [FreeFunction("ScheduleManagedJobParallelForTransformReadOnly", ThrowsException = True)]
        public static JobHandle ScheduleParallelForTransformReadOnly(ref JobScheduleParameters parameters, nint transfromAccesssArray, int innerloopBatchCount);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        [NativeMethod(IsThreadSafe = True, IsFreeFunction = True)]
        public static void PatchBufferMinMaxRanges(nint bufferRangePatchData, void* jobdata, int startIndex, int rangeSize);
        [Obsolete("JobType is obsolete. The parameter should be removed. (UnityUpgradable) -> !1")]
        public static nint CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null);
        public static nint CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null);
        [Obsolete("JobType is obsolete. The parameter should be removed. (UnityUpgradable) -> !2")]
        public static nint CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0);
        public static nint CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0);
        [FreeFunction("JobSystem::ResetJobQueueWorkerThreadCount")]
        public static void ResetJobWorkerCount();
        public struct JobScheduleParameters
        {

            public JobHandle Dependency;
            public int ScheduleMode;
            public nint ReflectionData;
            public nint JobDataPtr;

            public JobScheduleParameters(void* i_jobData, nint i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode);
        }
    }
}
