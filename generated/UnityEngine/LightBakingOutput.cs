#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/SharedLightData.h")]
    public struct LightBakingOutput
    {

        public int probeOcclusionLightIndex;
        public int occlusionMaskChannel;
        [NativeName("lightmapBakeMode.lightmapBakeType")]
        public LightmapBakeType lightmapBakeType;
        [NativeName("lightmapBakeMode.mixedLightingMode")]
        public MixedLightingMode mixedLightingMode;
        public bool isBaked;
    }
}
