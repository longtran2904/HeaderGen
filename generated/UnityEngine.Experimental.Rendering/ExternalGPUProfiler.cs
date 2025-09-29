#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    public static class ExternalGPUProfiler
    {
        [FreeFunction("ExternalGPUProfilerBindings::BeginGPUCapture")]
        public static void BeginGPUCapture();
        [FreeFunction("ExternalGPUProfilerBindings::EndGPUCapture")]
        public static void EndGPUCapture();
        [FreeFunction("ExternalGPUProfilerBindings::IsAttached")]
        public static bool IsAttached();
    }
}
