#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
    [StaticAccessor("VirtualTexturing::Streaming", StaticAccessorType.DoubleColon)]
    public static class Streaming
    {
        [NativeThrows]
        public static void RequestRegion([NotNull("ArgumentNullException")] Material mat, int stackNameId, Rect r, int mipMap, int numMips);
        [NativeThrows]
        public static void GetTextureStackSize([NotNull("ArgumentNullException")] Material mat, int stackNameId, out int width, out int height);
        [NativeThrows]
        public static void SetCPUCacheSize(int sizeInMegabytes);
        [NativeThrows]
        public static int GetCPUCacheSize();
        [NativeThrows]
        public static void SetGPUCacheSettings(GPUCacheSetting[] cacheSettings);
        [NativeThrows]
        public static GPUCacheSetting[] GetGPUCacheSettings();
    }
}
