#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
    [NativeHeader("Runtime/Profiler/Marker.h")]
    [NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
    [UsedByNativeCode]
    public sealed class CustomSampler : Sampler
    {
        public static CustomSampler Create(string name, bool collectGpuData = False);
        [Conditional("ENABLE_PROFILER")]
        public void Begin();
        [Conditional("ENABLE_PROFILER")]
        public void Begin(Object targetObject);
        [Conditional("ENABLE_PROFILER")]
        public void End();
    }
}
