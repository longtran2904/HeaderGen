#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class SupportedRenderingFeatures
    {
        public SupportedRenderingFeatures();

        public static SupportedRenderingFeatures active { get; set; }
        public ReflectionProbeModes reflectionProbeModes { get; set; }
        public LightmapMixedBakeModes defaultMixedLightingModes { get; set; }
        public LightmapMixedBakeModes mixedLightingModes { get; set; }
        public LightmapBakeType lightmapBakeTypes { get; set; }
        public LightmapsMode lightmapsModes { get; set; }
        public bool enlightenLightmapper { get; set; }
        public bool enlighten { get; set; }
        public bool lightProbeProxyVolumes { get; set; }
        public bool motionVectors { get; set; }
        public bool receiveShadows { get; set; }
        public bool reflectionProbes { get; set; }
        public bool reflectionProbesBlendDistance { get; set; }
        public bool rendererPriority { get; set; }
        public bool rendersUIOverlay { get; set; }
        public bool overridesEnvironmentLighting { get; set; }
        public bool overridesFog { get; set; }
        public bool overridesRealtimeReflectionProbes { get; set; }
        public bool overridesOtherLightingSettings { get; set; }
        public bool editableMaterialRenderQueue { get; set; }
        public bool overridesLODBias { get; set; }
        public bool overridesMaximumLODLevel { get; set; }
        public bool rendererProbes { get; set; }
        public bool particleSystemInstancing { get; set; }
        public bool autoAmbientProbeBaking { get; set; }
        public bool autoDefaultReflectionProbeBaking { get; set; }
        public bool overridesShadowmask { get; set; }
        public string overrideShadowmaskMessage { get; set; }
        public string shadowmaskMessage { get; }
        [Obsolete("terrainDetailUnsupported is deprecated.")]
        public bool terrainDetailUnsupported { get; set; }

        [Flags]
        public enum ReflectionProbeModes
        {
            None = 0,
            Rotation = 1
        }
        [Flags]
        public enum LightmapMixedBakeModes
        {
            None = 0,
            IndirectOnly = 1,
            Subtractive = 2,
            Shadowmask = 4
        }
    }
}
