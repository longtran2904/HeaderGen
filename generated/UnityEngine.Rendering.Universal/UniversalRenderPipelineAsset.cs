#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;
using UnityEditor.ShaderKeywordFilter;

namespace UnityEngine.Rendering.Universal
{
    [ApplyRulesIfTagsEqual(new[] {"RenderPipeline", "UniversalPipeline" })]
    [ExcludeFromPreset]
    public class UniversalRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver
    {
        public static readonly int AdditionalLightsDefaultShadowResolutionTierLow;
        public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium;
        public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh;
        public static readonly string packagePath;
        public static readonly string editorResourcesGUID;
        public const int k_MinLutSize = 16;
        public const int k_MaxLutSize = 65;

        public UniversalRenderPipelineAsset();

        public ScriptableRenderer scriptableRenderer { get; }
        public bool supportsCameraDepthTexture { get; set; }
        public bool supportsCameraOpaqueTexture { get; set; }
        public Downsampling opaqueDownsampling { get; }
        public bool supportsTerrainHoles { get; }
        public StoreActionsOptimization storeActionsOptimization { get; set; }
        public bool supportsHDR { get; set; }
        public int msaaSampleCount { get; set; }
        public float renderScale { get; set; }
        public UpscalingFilterSelection upscalingFilter { get; set; }
        public bool fsrOverrideSharpness { get; set; }
        public float fsrSharpness { get; set; }
        public LightRenderingMode mainLightRenderingMode { get; }
        public bool supportsMainLightShadows { get; }
        public int mainLightShadowmapResolution { get; }
        public LightRenderingMode additionalLightsRenderingMode { get; }
        public int maxAdditionalLightsCount { get; set; }
        public bool supportsAdditionalLightShadows { get; }
        public int additionalLightsShadowmapResolution { get; }
        public int additionalLightsShadowResolutionTierLow { get; }
        public int additionalLightsShadowResolutionTierMedium { get; }
        public int additionalLightsShadowResolutionTierHigh { get; }
        public bool reflectionProbeBlending { get; }
        public bool reflectionProbeBoxProjection { get; }
        public float shadowDistance { get; set; }
        public int shadowCascadeCount { get; set; }
        public float cascade2Split { get; }
        public Vector2 cascade3Split { get; }
        public Vector3 cascade4Split { get; }
        public float cascadeBorder { get; set; }
        public float shadowDepthBias { get; set; }
        public float shadowNormalBias { get; set; }
        public bool supportsSoftShadows { get; }
        public bool supportsDynamicBatching { get; set; }
        public bool supportsMixedLighting { get; }
        public bool supportsLightLayers { get; }
        public ShaderVariantLogLevel shaderVariantLogLevel { get; set; }
        public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode { get; }
        [Obsolete("PipelineDebugLevel is deprecated. Calling debugLevel is not necessary.", False)]
        public PipelineDebugLevel debugLevel { get; }
        public bool useSRPBatcher { get; set; }
        public ColorGradingMode colorGradingMode { get; set; }
        public int colorGradingLutSize { get; set; }
        public bool useFastSRGBLinearConversion { get; }
        public bool useAdaptivePerformance { get; set; }
        public bool conservativeEnclosingSphere { get; set; }
        public int numIterationsEnclosingSphere { get; set; }
        public override Material defaultMaterial { get; }
        public override Material defaultParticleMaterial { get; }
        public override Material defaultLineMaterial { get; }
        public override Material defaultTerrainMaterial { get; }
        public override Material defaultUIMaterial { get; }
        public override Material defaultUIOverdrawMaterial { get; }
        public override Material defaultUIETC1SupportedMaterial { get; }
        public override Material default2DMaterial { get; }
        public override Material default2DMaskMaterial { get; }
        public Material decalMaterial { get; }
        public override Shader defaultShader { get; }
        public override Shader autodeskInteractiveShader { get; }
        public override Shader autodeskInteractiveTransparentShader { get; }
        public override Shader autodeskInteractiveMaskedShader { get; }
        public override Shader terrainDetailLitShader { get; }
        public override Shader terrainDetailGrassShader { get; }
        public override Shader terrainDetailGrassBillboardShader { get; }
        public override Shader defaultSpeedTree7Shader { get; }
        public override Shader defaultSpeedTree8Shader { get; }
        public override string[] renderingLayerMaskNames { get; }
        public override string[] prefixedRenderingLayerMaskNames { get; }
        public string[] lightLayerMaskNames { get; }
        [Obsolete("This is obsolete, please use shadowCascadeCount instead.", False)]
        public ShadowCascadesOption shadowCascadeOption { get; set; }

        public static UniversalRenderPipelineAsset Create(ScriptableRendererData rendererData = null);
        public ScriptableRendererData LoadBuiltinRendererData(RendererType type = RendererType.UniversalRenderer);
        protected override RenderPipeline CreatePipeline();
        protected override void OnValidate();
        protected override void OnDisable();
        public ScriptableRenderer GetRenderer(int index);
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
