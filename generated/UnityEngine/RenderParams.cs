#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine
{
    public struct RenderParams
    {

        public RenderParams(Material mat);

        public int layer { get; set; }
        public uint renderingLayerMask { get; set; }
        public int rendererPriority { get; set; }
        public Bounds worldBounds { get; set; }
        public Camera camera { get; set; }
        public MotionVectorGenerationMode motionVectorMode { get; set; }
        public ReflectionProbeUsage reflectionProbeUsage { get; set; }
        public Material material { get; set; }
        public MaterialPropertyBlock matProps { get; set; }
        public ShadowCastingMode shadowCastingMode { get; set; }
        public bool receiveShadows { get; set; }
        public LightProbeUsage lightProbeUsage { get; set; }
        public LightProbeProxyVolume lightProbeProxyVolume { get; set; }
    }
}
