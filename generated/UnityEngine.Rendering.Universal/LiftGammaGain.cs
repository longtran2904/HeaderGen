#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Lift, Gamma, Gain", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
    {
        [Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
        public Vector4Parameter lift;
        [Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
        public Vector4Parameter gamma;
        [Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
        public Vector4Parameter gain;

        public LiftGammaGain();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
