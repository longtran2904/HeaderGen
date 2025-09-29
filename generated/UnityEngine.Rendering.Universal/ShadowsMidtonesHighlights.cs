#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Shadows, Midtones, Highlights", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
    {

        [Tooltip("Use this to control and apply a hue to the shadows.")]
        public Vector4Parameter shadows;
        [Tooltip("Use this to control and apply a hue to the midtones.")]
        public Vector4Parameter midtones;
        [Tooltip("Use this to control and apply a hue to the highlights.")]
        public Vector4Parameter highlights;
        [Header("Shadow Limits")]
        [Tooltip("Start point of the transition between shadows and midtones.")]
        public MinFloatParameter shadowsStart;
        [Tooltip("End point of the transition between shadows and midtones.")]
        public MinFloatParameter shadowsEnd;
        [Header("Highlight Limits")]
        [Tooltip("Start point of the transition between midtones and highlights.")]
        public MinFloatParameter highlightsStart;
        [Tooltip("End point of the transition between midtones and highlights.")]
        public MinFloatParameter highlightsEnd;

        public ShadowsMidtonesHighlights();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
