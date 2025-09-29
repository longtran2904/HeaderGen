#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.ParticleSystemJobs
{
    [JobProducerType(typeof(ParticleSystemParallelForJobStruct<>))]
    public interface IJobParticleSystemParallelFor
    {

        void Execute(ParticleSystemJobData jobData, int index);
    }
}
