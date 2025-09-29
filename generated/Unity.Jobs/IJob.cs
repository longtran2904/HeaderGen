#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
    [JobProducerType(typeof(IJobExtensions.JobStruct<>))]
    public interface IJob
    {
        void Execute();
    }
}
