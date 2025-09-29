#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditorInternal
{
    [Flags]
    [NativeHeader("Modules/Profiler/Public/ProfilerStatsBase.h")]
    [RequiredByNativeCode]
    public enum GpuProfilingStatisticsAvailabilityStates
    {

        Gathered = 1,
        Enabled = 2,
        Supported = 4,
        [Obsolete("This has been made obsolete. GPU Profiling is supported in Edit Mode.", False)]
        NotSupportedWithEditorProfiling = 8,
        NotSupportedWithLegacyGfxJobs = 16,
        NotSupportedWithNativeGfxJobs = 32,
        NotSupportedByDevice = 64,
        NotSupportedByGraphicsAPI = 128,
        NotSupportedDueToFrameTimingStatsAndDisjointTimerQuery = 256,
        NotSupportedWithVulkan = 512,
        NotSupportedWithMetal = 1024,
        NotSupportedWithOpenGLGPURecorders = 2048
    }
}
