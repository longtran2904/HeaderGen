#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace Unity.Jobs
{
    public static class IJobForExtensions
    {
        public static JobHandle Schedule<T>(this T jobData, int arrayLength, JobHandle dependency) where T : IJobFor, struct;
        public static JobHandle ScheduleParallel<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) where T : IJobFor, struct;
        public static void Run<T>(this T jobData, int arrayLength) where T : IJobFor, struct;
    }
}
