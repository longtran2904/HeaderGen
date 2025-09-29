#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;

namespace Unity.Jobs
{
    [NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
    public struct JobHandle
    {
        public bool IsCompleted { get; }

        public void Complete();
        public static void CompleteAll(ref JobHandle job0, ref JobHandle job1);
        public static void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2);
        public static void CompleteAll(NativeArray<JobHandle> jobs);
        [NativeMethod("ScheduleBatchedScriptingJobs", IsThreadSafe = True, IsFreeFunction = True)]
        public static void ScheduleBatchedJobs();
        public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1);
        public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2);
        public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs);
        public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs);
        [NativeMethod(IsThreadSafe = True, IsFreeFunction = True)]
        public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn);
    }
}
