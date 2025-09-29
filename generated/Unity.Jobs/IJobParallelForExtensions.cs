#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace Unity.Jobs
{
    public static class IJobParallelForExtensions
    {

        public static JobHandle Schedule<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) where T : IJobParallelFor, struct;
        public static void Run<T>(this T jobData, int arrayLength) where T : IJobParallelFor, struct;
    }
}
