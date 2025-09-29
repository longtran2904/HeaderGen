#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace Unity.Profiling
{
    [Flags]
    public enum ProfilerRecorderOptions
    {

        None = 0,
        StartImmediately = 1,
        KeepAliveDuringDomainReload = 2,
        CollectOnlyOnCurrentThread = 4,
        WrapAroundWhenCapacityReached = 8,
        SumAllSamplesInFrame = 16,
        GpuRecorder = 64,
        Default = 24
    }
}
