#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/GfxDevice/FrameTiming.h")]
    public struct FrameTiming
    {

        [NativeName("m_CPUTimePresentCalled")]
        public ulong cpuTimePresentCalled;
        [NativeName("m_CPUFrameTime")]
        public double cpuFrameTime;
        [NativeName("m_CPUTimeFrameComplete")]
        public ulong cpuTimeFrameComplete;
        [NativeName("m_GPUFrameTime")]
        public double gpuFrameTime;
        [NativeName("m_HeightScale")]
        public float heightScale;
        [NativeName("m_WidthScale")]
        public float widthScale;
        [NativeName("m_SyncInterval")]
        public uint syncInterval;
    }
}
