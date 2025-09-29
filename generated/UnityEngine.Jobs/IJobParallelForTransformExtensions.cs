#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Jobs;

namespace UnityEngine.Jobs
{
    public static class IJobParallelForTransformExtensions
    {

        public static JobHandle Schedule<T>(this T jobData, TransformAccessArray transforms, JobHandle dependsOn = null) where T : IJobParallelForTransform, struct;
        public static JobHandle ScheduleReadOnly<T>(this T jobData, TransformAccessArray transforms, int batchSize, JobHandle dependsOn = null) where T : IJobParallelForTransform, struct;
        public static void RunReadOnly<T>(this T jobData, TransformAccessArray transforms) where T : IJobParallelForTransform, struct;
    }
}
