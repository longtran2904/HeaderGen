#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace Unity.Profiling.LowLevel
{
    [Flags]
    public enum MarkerFlags
    {

        Default = 0,
        Script = 2,
        ScriptInvoke = 32,
        ScriptDeepProfiler = 64,
        AvailabilityEditor = 4,
        AvailabilityNonDevelopment = 8,
        Warning = 16,
        Counter = 128,
        SampleGPU = 256
    }
}
