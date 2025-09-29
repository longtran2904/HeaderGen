#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/GI/Enlighten/LightmapParameters.h")]
    [PreventReadOnlyInstanceModification]
    public sealed class LightmapParameters : UnityEngine.Object
    {

        public LightmapParameters();

        public float resolution { get; set; }
        public float clusterResolution { get; set; }
        public int irradianceBudget { get; set; }
        public int irradianceQuality { get; set; }
        public float modellingTolerance { get; set; }
        [NativeName("EdgeStitching")]
        public bool stitchEdges { get; set; }
        public bool isTransparent { get; set; }
        public int systemTag { get; set; }
        public int blurRadius { get; set; }
        public int antiAliasingSamples { get; set; }
        public int directLightQuality { get; set; }
        public float pushoff { get; set; }
        public int bakedLightmapTag { get; set; }
        public bool limitLightmapCount { get; set; }
        public int maxLightmapCount { get; set; }
        public int AOQuality { get; set; }
        public int AOAntiAliasingSamples { get; set; }
        public float backFaceTolerance { get; set; }
        [Obsolete("edgeStitching has been deprecated. Use stitchEdges instead")]
        public float edgeStitching { get; set; }

        public static LightmapParameters GetLightmapParametersForLightingSettings(LightingSettings lightingSettings);
        public static void SetLightmapParametersForLightingSettings(LightmapParameters parameters, LightingSettings lightingSettings);
        public void AssignToLightingSettings(LightingSettings lightingSettings);
    }
}
