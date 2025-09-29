#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/Audio/Public/AudioManager.h")]
    [NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
    [NativeHeader("Runtime/Profiler/MemoryProfilerStats.h")]
    [NativeHeader("Runtime/GfxDevice/GfxDeviceStats.h")]
    [NativeHeader("Runtime/Graphics/RenderTexture.h")]
    [StaticAccessor("GfxDeviceStats::Get().GetLegacyFrameStats()", StaticAccessorType.Dot)]
    public sealed class UnityStats
    {

        public UnityStats();

        public static int batches { get; }
        public static int drawCalls { get; }
        public static int dynamicBatchedDrawCalls { get; }
        public static int staticBatchedDrawCalls { get; }
        public static int instancedBatchedDrawCalls { get; }
        public static int dynamicBatches { get; }
        public static int staticBatches { get; }
        public static int instancedBatches { get; }
        public static int setPassCalls { get; }
        public static int triangles { get; }
        public static int vertices { get; }
        public static int shadowCasters { get; }
        public static int renderTextureChanges { get; }
        [NativeName("MainThreadFrameTime")]
        public static float frameTime { get; }
        [NativeName("RenderThreadFrameTime")]
        public static float renderTime { get; }
        public static float audioLevel { get; }
        public static float audioClippingAmount { get; }
        public static float audioDSPLoad { get; }
        public static float audioStreamLoad { get; }
        public static int renderTextureCount { get; }
        public static int renderTextureBytes { get; }
        public static int usedTextureMemorySize { get; }
        public static int usedTextureCount { get; }
        public static string screenRes { get; }
        public static int screenBytes { get; }
        public static int vboTotal { get; }
        public static int vboTotalBytes { get; }
        public static int vboUploads { get; }
        public static int vboUploadBytes { get; }
        public static int ibUploads { get; }
        public static int ibUploadBytes { get; }
        public static int visibleSkinnedMeshes { get; }
        public static int animationComponentsPlaying { get; }
        public static int animatorComponentsPlaying { get; }
    }
}
