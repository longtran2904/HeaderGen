#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Light))]
    [URPHelpURL("universal-additional-light-data")]
    public class UniversalAdditionalLightData : MonoBehaviour, IAdditionalData
    {

        public static readonly int AdditionalLightsShadowResolutionTierCustom;
        public static readonly int AdditionalLightsShadowResolutionTierLow;
        public static readonly int AdditionalLightsShadowResolutionTierMedium;
        public static readonly int AdditionalLightsShadowResolutionTierHigh;
        public static readonly int AdditionalLightsShadowDefaultResolutionTier;
        public static readonly int AdditionalLightsShadowDefaultCustomResolution;
        public static readonly int AdditionalLightsShadowMinimumResolution;

        public UniversalAdditionalLightData();

        public bool usePipelineSettings { get; set; }
        public int additionalLightsShadowResolutionTier { get; }
        public LightLayerEnum lightLayerMask { get; set; }
        public bool customShadowLayers { get; set; }
        public LightLayerEnum shadowLayerMask { get; set; }
        public Vector2 lightCookieSize { get; set; }
        public Vector2 lightCookieOffset { get; set; }
    }
}
