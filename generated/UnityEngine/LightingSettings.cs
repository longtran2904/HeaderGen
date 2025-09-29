#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/LightingSettings.h")]
    [PreventReadOnlyInstanceModification]
    public sealed class LightingSettings : Object
    {

        public LightingSettings();

        [NativeName("EnableBakedLightmaps")]
        public bool bakedGI { get; set; }
        [NativeName("EnableRealtimeLightmaps")]
        public bool realtimeGI { get; set; }
        [NativeName("RealtimeEnvironmentLighting")]
        public bool realtimeEnvironmentLighting { get; set; }
        [NativeName("AutoGenerate")]
        public bool autoGenerate { get; set; }
        [NativeName("MixedBakeMode")]
        public MixedLightingMode mixedBakeMode { get; set; }
        [NativeName("AlbedoBoost")]
        public float albedoBoost { get; set; }
        [NativeName("IndirectOutputScale")]
        public float indirectScale { get; set; }
        [NativeName("BakeBackend")]
        public Lightmapper lightmapper { get; set; }
        [NativeName("LightmapMaxSize")]
        public int lightmapMaxSize { get; set; }
        [NativeName("BakeResolution")]
        public float lightmapResolution { get; set; }
        [NativeName("Padding")]
        public int lightmapPadding { get; set; }
        [NativeName("LightmapCompression")]
        public LightmapCompression lightmapCompression { get; set; }
        [NativeName("TextureCompression")]
        [Obsolete("Use LightingSettings.lightmapCompression instead.")]
        public bool compressLightmaps { get; set; }
        [NativeName("AO")]
        public bool ao { get; set; }
        [NativeName("AOMaxDistance")]
        public float aoMaxDistance { get; set; }
        [NativeName("CompAOExponent")]
        public float aoExponentIndirect { get; set; }
        [NativeName("CompAOExponentDirect")]
        public float aoExponentDirect { get; set; }
        [NativeName("ExtractAO")]
        public bool extractAO { get; set; }
        [NativeName("LightmapsBakeMode")]
        public LightmapsMode directionalityMode { get; set; }
        public bool exportTrainingData { get; set; }
        public string trainingDataDestination { get; set; }
        [NativeName("RealtimeResolution")]
        public float indirectResolution { get; set; }
        public bool finalGather { get; set; }
        public float finalGatherRayCount { get; set; }
        public bool finalGatherFiltering { get; set; }
        [NativeName("PVRSampling")]
        public Sampling sampling { get; set; }
        [NativeName("PVRDirectSampleCount")]
        public int directSampleCount { get; set; }
        [NativeName("PVRSampleCount")]
        public int indirectSampleCount { get; set; }
        [NativeName("PVRBounces")]
        [Obsolete("Use LightingSettings.maxBounces instead. (UnityUpgradable) -> UnityEngine.LightingSettings.maxBounces", False)]
        public int bounces { get; set; }
        [NativeName("PVRBounces")]
        public int maxBounces { get; set; }
        [NativeName("PVRMinBounces")]
        [Obsolete("Use LightingSettings.minBounces instead. (UnityUpgradable) -> UnityEngine.LightingSettings.minBounces", False)]
        public int russianRouletteStartBounce { get; set; }
        [NativeName("PVRMinBounces")]
        public int minBounces { get; set; }
        [NativeName("PVRCulling")]
        public bool prioritizeView { get; set; }
        [NativeName("PVRFilteringMode")]
        public FilterMode filteringMode { get; set; }
        [NativeName("PVRDenoiserTypeDirect")]
        public DenoiserType denoiserTypeDirect { get; set; }
        [NativeName("PVRDenoiserTypeIndirect")]
        public DenoiserType denoiserTypeIndirect { get; set; }
        [NativeName("PVRDenoiserTypeAO")]
        public DenoiserType denoiserTypeAO { get; set; }
        [NativeName("PVRFilterTypeDirect")]
        public FilterType filterTypeDirect { get; set; }
        [NativeName("PVRFilterTypeIndirect")]
        public FilterType filterTypeIndirect { get; set; }
        [NativeName("PVRFilterTypeAO")]
        public FilterType filterTypeAO { get; set; }
        [NativeName("PVRFilteringGaussRadiusDirect")]
        public int filteringGaussRadiusDirect { get; set; }
        [NativeName("PVRFilteringGaussRadiusIndirect")]
        public int filteringGaussRadiusIndirect { get; set; }
        [NativeName("PVRFilteringGaussRadiusAO")]
        public int filteringGaussRadiusAO { get; set; }
        [NativeName("PVRFilteringAtrousPositionSigmaDirect")]
        public float filteringAtrousPositionSigmaDirect { get; set; }
        [NativeName("PVRFilteringAtrousPositionSigmaIndirect")]
        public float filteringAtrousPositionSigmaIndirect { get; set; }
        [NativeName("PVRFilteringAtrousPositionSigmaAO")]
        public float filteringAtrousPositionSigmaAO { get; set; }
        [NativeName("PVREnvironmentSampleCount")]
        public int environmentSampleCount { get; set; }
        [NativeName("LightProbeSampleCountMultiplier")]
        public float lightProbeSampleCountMultiplier { get; set; }
        public enum Lightmapper
        {

            Enlighten = 0,
            ProgressiveCPU = 1,
            ProgressiveGPU = 2
        }
        public enum Sampling
        {

            Auto = 0,
            Fixed = 1
        }
        public enum FilterMode
        {

            None = 0,
            Auto = 1,
            Advanced = 2
        }
        public enum DenoiserType
        {

            None = 0,
            Optix = 1,
            OpenImage = 2,
            RadeonPro = 3
        }
        public enum FilterType
        {

            Gaussian = 0,
            ATrous = 1,
            None = 2
        }
    }
}
