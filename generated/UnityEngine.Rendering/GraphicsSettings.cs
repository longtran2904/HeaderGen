#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Camera/GraphicsSettings.h")]
    [StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
    public sealed class GraphicsSettings : Object
    {
        public static TransparencySortMode transparencySortMode { get; set; }
        public static Vector3 transparencySortAxis { get; set; }
        public static bool realtimeDirectRectangularAreaLights { get; set; }
        public static bool lightsUseLinearIntensity { get; set; }
        public static bool lightsUseColorTemperature { get; set; }
        public static uint defaultRenderingLayerMask { get; set; }
        public static bool useScriptableRenderPipelineBatching { get; set; }
        public static bool logWhenShaderIsCompiled { get; set; }
        public static bool disableBuiltinCustomRenderTextureUpdate { get; set; }
        public static VideoShadersIncludeMode videoShadersIncludeMode { get; set; }
        public static RenderPipelineAsset currentRenderPipeline { get; }
        public static RenderPipelineAsset renderPipelineAsset { get; set; }
        public static RenderPipelineAsset defaultRenderPipeline { get; set; }
        public static RenderPipelineAsset[] allConfiguredRenderPipelines { get; }
        public static bool cameraRelativeLightCulling { get; set; }
        public static bool cameraRelativeShadowCulling { get; set; }

        public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash);
        public static bool HasShaderDefine(BuiltinShaderDefine defineHash);
        [FreeFunction]
        public static Object GetGraphicsSettings();
        [NativeName("SetShaderModeScript")]
        public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode);
        [NativeName("GetShaderModeScript")]
        public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type);
        [NativeName("SetCustomShaderScript")]
        public static void SetCustomShader(BuiltinShaderType type, Shader shader);
        [NativeName("GetCustomShaderScript")]
        public static Shader GetCustomShader(BuiltinShaderType type);
        public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline;
        public static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline;
        public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline;
    }
}
