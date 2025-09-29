#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/LightmapEditorSettings.h")]
    public static class LightmapEditorSettings
    {
        [Obsolete("LightmapEditorSettings.lightmapper is obsolete, use Lightmapping.lightingSettings.lightmapper instead. ", False)]
        public static Lightmapper lightmapper { get; set; }
        [Obsolete("LightmapEditorSettings.lightmapsMode is obsolete, use Lightmapping.lightingSettings.directionalityMode instead. ", False)]
        public static LightmapsMode lightmapsMode { get; set; }
        [Obsolete("LightmapEditorSettings.mixedBakeMode is obsolete, use Lightmapping.lightingSettings.mixedBakeMode instead. ", False)]
        public static MixedLightingMode mixedBakeMode { get; set; }
        [Obsolete("LightmapEditorSettings.sampling is obsolete, use Lightmapping.lightingSettings.sampling instead. ", False)]
        public static Sampling sampling { get; set; }
        [Obsolete("LightmapEditorSettings.directSampleCount is obsolete, use Lightmapping.lightingSettings.directSampleCount instead. ", False)]
        public static int directSampleCount { get; set; }
        [Obsolete("LightmapEditorSettings.indirectSampleCount is obsolete, use Lightmapping.lightingSettings.indirectSampleCount instead. ", False)]
        public static int indirectSampleCount { get; set; }
        [Obsolete("LightmapEditorSettings.bounces is obsolete, use Lightmapping.lightingSettings.maxBounces instead. ", False)]
        public static int bounces { get; set; }
        [Obsolete("LightmapEditorSettings.prioritizeView is obsolete, use Lightmapping.lightingSettings.prioritizeView instead. ", False)]
        public static bool prioritizeView { get; set; }
        [Obsolete("LightmapEditorSettings.filteringMode is obsolete, use Lightmapping.lightingSettings.filteringMode instead. ", False)]
        public static FilterMode filteringMode { get; set; }
        [Obsolete("LightmapEditorSettings.denoiserTypeDirect is obsolete, use Lightmapping.lightingSettings.denoiserTypeDirect instead. ", False)]
        public static DenoiserType denoiserTypeDirect { get; set; }
        [Obsolete("LightmapEditorSettings.denoiserTypeIndirect is obsolete, use Lightmapping.lightingSettings.denoiserTypeIndirect instead. ", False)]
        public static DenoiserType denoiserTypeIndirect { get; set; }
        [Obsolete("LightmapEditorSettings.denoiserTypeAO is obsolete, use Lightmapping.lightingSettings.denoiserTypeAO instead. ", False)]
        public static DenoiserType denoiserTypeAO { get; set; }
        [Obsolete("LightmapEditorSettings.filterTypeDirect is obsolete, use Lightmapping.lightingSettings.filterTypeDirect instead. ", False)]
        public static FilterType filterTypeDirect { get; set; }
        [Obsolete("LightmapEditorSettings.filterTypeIndirect is obsolete, use Lightmapping.lightingSettings.filterTypeIndirect instead. ", False)]
        public static FilterType filterTypeIndirect { get; set; }
        [Obsolete("LightmapEditorSettings.filterTypeAO is obsolete, use Lightmapping.lightingSettings.filterTypeAO instead. ", False)]
        public static FilterType filterTypeAO { get; set; }
        [Obsolete("LightmapEditorSettings.filteringGaussRadiusDirect is obsolete, use Lightmapping.lightingSettings.filteringGaussRadiusDirect instead. ", False)]
        public static int filteringGaussRadiusDirect { get; set; }
        [Obsolete("LightmapEditorSettings.filteringGaussRadiusIndirect is obsolete, use Lightmapping.lightingSettings.filteringGaussRadiusIndirect instead. ", False)]
        public static int filteringGaussRadiusIndirect { get; set; }
        [Obsolete("LightmapEditorSettings.filteringGaussRadiusAO is obsolete, use Lightmapping.lightingSettings.filteringGaussRadiusAO instead. ", False)]
        public static int filteringGaussRadiusAO { get; set; }
        [Obsolete("LightmapEditorSettings.filteringAtrousPositionSigmaDirect is obsolete, use Lightmapping.lightingSettings.filteringAtrousPositionSigmaDirect instead. ", False)]
        public static float filteringAtrousPositionSigmaDirect { get; set; }
        [Obsolete("LightmapEditorSettings.filteringAtrousPositionSigmaIndirect is obsolete, use Lightmapping.lightingSettings.filteringAtrousPositionSigmaIndirect instead. ", False)]
        public static float filteringAtrousPositionSigmaIndirect { get; set; }
        [Obsolete("LightmapEditorSettings.filteringAtrousPositionSigmaIndirect is obsolete, use Lightmapping.lightingSettings.filteringAtrousPositionSigmaIndirect instead. ", False)]
        public static float filteringAtrousPositionSigmaAO { get; set; }
        [Obsolete("LightmapEditorSettings.environmentSampleCount is obsolete, use Lightmapping.lightingSettings.environmentSampleCount instead. ", False)]
        public static int environmentSampleCount { get; set; }
        [Obsolete("LightmapEditorSettings.maxAtlasSize is obsolete, use Lightmapping.lightingSettings.lightmapMaxSize instead. ", False)]
        public static int maxAtlasSize { get; set; }
        [Obsolete("LightmapEditorSettings.realtimeResolution is obsolete, use Lightmapping.lightingSettings.indirectResolution instead. ", False)]
        public static float realtimeResolution { get; set; }
        [Obsolete("LightmapEditorSettings.bakeResolution is obsolete, use Lightmapping.lightingSettings.lightmapResolution instead. ", False)]
        public static float bakeResolution { get; set; }
        [Obsolete("LightmapEditorSettings.textureCompression is obsolete, use Lightmapping.lightingSettings.compressLightmaps instead. ", False)]
        public static bool textureCompression { get; set; }
        [NativeName("ReflectionCompression")]
        [StaticAccessor("GetLightmapEditorSettings()")]
        public static ReflectionCubemapCompression reflectionCubemapCompression { get; set; }
        [Obsolete("LightmapEditorSettings.enableAmbientOcclusion is obsolete, use Lightmapping.lightingSettings.ao instead. ", False)]
        public static bool enableAmbientOcclusion { get; set; }
        [Obsolete("LightmapEditorSettings.aoMaxDistance is obsolete, use Lightmapping.lightingSettings.aoMaxDistance instead. ", False)]
        public static float aoMaxDistance { get; set; }
        [Obsolete("LightmapEditorSettings.aoExponentIndirect is obsolete, use Lightmapping.lightingSettings.aoExponentIndirect instead. ", False)]
        public static float aoExponentIndirect { get; set; }
        [Obsolete("LightmapEditorSettings.aoExponentDirect is obsolete, use Lightmapping.lightingSettings.aoExponentDirect instead. ", False)]
        public static float aoExponentDirect { get; set; }
        [Obsolete("LightmapEditorSettings.padding is obsolete, use Lightmapping.lightingSettings.lightmapPadding instead. ", False)]
        public static int padding { get; set; }
        [Obsolete("LightmapEditorSettings.exportTrainingData is obsolete, use Lightmapping.lightingSettings.exportTrainingData instead. ", False)]
        public static bool exportTrainingData { get; set; }
        [Obsolete("LightmapEditorSettings.trainingDataDestination is obsolete, use Lightmapping.lightingSettings.trainingDataDestination instead. ", False)]
        public static string trainingDataDestination { get; set; }
        [Obsolete("LightmapEditorSettings.aoContrast has been deprecated.", False)]
        public static float aoContrast { get; set; }
        [Obsolete("LightmapEditorSettings.aoAmount has been deprecated.", False)]
        public static float aoAmount { get; set; }
        [Obsolete("LightmapEditorSettings.lockAtlas has been deprecated.", False)]
        public static bool lockAtlas { get; set; }
        [Obsolete("LightmapEditorSettings.skyLightColor has been deprecated.", False)]
        public static Color skyLightColor { get; set; }
        [Obsolete("LightmapEditorSettings.skyLightIntensity has been deprecated.", False)]
        public static float skyLightIntensity { get; set; }
        [Obsolete("LightmapEditorSettings.quality has been deprecated.", False)]
        public static LightmapBakeQuality quality { get; set; }
        [Obsolete("LightmapEditorSettings.bounceBoost has been deprecated.", False)]
        public static float bounceBoost { get; set; }
        [Obsolete("LightmapEditorSettings.finalGatherRays has been deprecated.", False)]
        public static int finalGatherRays { get; set; }
        [Obsolete("LightmapEditorSettings.finalGatherContrastThreshold has been deprecated.", False)]
        public static float finalGatherContrastThreshold { get; set; }
        [Obsolete("LightmapEditorSettings.finalGatherGradientThreshold has been deprecated.", False)]
        public static float finalGatherGradientThreshold { get; set; }
        [Obsolete("LightmapEditorSettings.finalGatherInterpolationPoints has been deprecated.", False)]
        public static int finalGatherInterpolationPoints { get; set; }
        [Obsolete("LightmapEditorSettings.lastUsedResolution has been deprecated.", False)]
        public static float lastUsedResolution { get; set; }
        [Obsolete("LightmapEditorSettings.bounceIntensity has been deprecated.", False)]
        public static float bounceIntensity { get; set; }
        [Obsolete("resolution is now called realtimeResolution (UnityUpgradable) -> realtimeResolution", False)]
        public static float resolution { get; set; }
        [Obsolete("The giBakeBackend property has been renamed to lightmapper. (UnityUpgradable) -> lightmapper", False)]
        public static GIBakeBackend giBakeBackend { get; set; }
        [Obsolete("The giPathTracerSampling property has been renamed to sampling. (UnityUpgradable) -> sampling", False)]
        public static PathTracerSampling giPathTracerSampling { get; set; }
        [Obsolete("The giPathTracerFilter property has been deprecated. There are three independent properties to set individual filter types for direct, indirect and AO GI textures: filterTypeDirect, filterTypeIndirect and filterTypeAO.")]
        public static PathTracerFilter giPathTracerFilter { get; set; }
        [Obsolete("LightmapEditorSettings.maxAtlasWidth is now called maxAtlasSize (UnityUpgradable) -> maxAtlasSize", False)]
        public static int maxAtlasWidth { get; set; }
        [Obsolete("LightmapEditorSettings.maxAtlasHeight has been deprecated. Only square atlases are supported, please use the maxAtlasSize instead. ")]
        public static int maxAtlasHeight { get; set; }

        [Obsolete("LightmapEditorSettings.Lightmapper is obsolete. Use LightingSettings.Lightmapper instead. ", False)]
        public enum Lightmapper
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use Lightmapper.Enlighten instead. (UnityUpgradable) -> UnityEditor.LightmapEditorSettings/Lightmapper.Enlighten", True)]
            Radiosity = 0,
            Enlighten = 0,
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use Lightmapper.ProgressiveCPU instead. (UnityUpgradable) -> UnityEditor.LightmapEditorSettings/Lightmapper.ProgressiveCPU", True)]
            PathTracer = 1,
            ProgressiveCPU = 1,
            ProgressiveGPU = 2
        }
        [Obsolete("LightmapEditorSettings.Sampling is obsolete. Use LightingSettings.Sampling instead. ", False)]
        public enum Sampling
        {
            Auto = 0,
            Fixed = 1
        }
        [Obsolete("LightmapEditorSettings.FilterMode is obsolete. Use LightingSettings.FilterMode instead. ", False)]
        public enum FilterMode
        {
            None = 0,
            Auto = 1,
            Advanced = 2
        }
        [Obsolete("LightmapEditorSettings.DenoiserType is obsolete. Use LightingSettings.DenoiserType instead. ", False)]
        public enum DenoiserType
        {
            None = 0,
            Optix = 1,
            OpenImage = 2,
            RadeonPro = 3
        }
        [Obsolete("LightmapEditorSettings.FilterType is obsolete. Use LightingSettings.FilterType instead. ", False)]
        public enum FilterType
        {
            Gaussian = 0,
            ATrous = 1,
            None = 2
        }
        [Obsolete("GIBakeBackend has been renamed to Lightmapper. (UnityUpgradable)", True)]
        public enum GIBakeBackend
        {
            Radiosity = 0,
            PathTracer = 1
        }
        [Obsolete("PathTracerSampling has been renamed to Sampling. (UnityUpgradable) -> UnityEditor.LightmapEditorSettings/Sampling", False)]
        public enum PathTracerSampling
        {
            Auto = 0,
            Fixed = 1
        }
        [Obsolete("PathTracerFilter has been renamed to FilterType. (UnityUpgradable) -> UnityEditor.LightmapEditorSettings/FilterType", False)]
        public enum PathTracerFilter
        {
            Gaussian = 0,
            ATrous = 1
        }
    }
}
