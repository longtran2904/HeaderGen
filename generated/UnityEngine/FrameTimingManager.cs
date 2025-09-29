#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [StaticAccessor("GetUncheckedRealGfxDevice().GetFrameTimingManager()", StaticAccessorType.Dot)]
    public static class FrameTimingManager
    {
        public static void CaptureFrameTimings();
        public static uint GetLatestTimings(uint numFrames, [Unmarshalled] FrameTiming[] timings);
        public static float GetVSyncsPerSecond();
        public static ulong GetGpuTimerFrequency();
        public static ulong GetCpuTimerFrequency();
    }
}
