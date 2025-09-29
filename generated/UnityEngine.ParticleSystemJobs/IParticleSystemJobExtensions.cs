#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using Unity.Jobs;

namespace UnityEngine.ParticleSystemJobs
{
    public static class IParticleSystemJobExtensions
    {
        public static JobHandle Schedule<T>(this T jobData, ParticleSystem ps, JobHandle dependsOn = null) where T : IJobParticleSystem, struct;
        public static JobHandle Schedule<T>(this T jobData, ParticleSystem ps, int minIndicesPerJobCount, JobHandle dependsOn = null) where T : IJobParticleSystemParallelFor, struct;
        public static JobHandle ScheduleBatch<T>(this T jobData, ParticleSystem ps, int innerLoopBatchCount, JobHandle dependsOn = null) where T : IJobParticleSystemParallelForBatch, struct;
    }
}
