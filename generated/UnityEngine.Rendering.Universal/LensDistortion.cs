#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Lens Distortion", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class LensDistortion : VolumeComponent, IPostProcessComponent
    {

        [Tooltip("Total distortion amount.")]
        public ClampedFloatParameter intensity;
        [Tooltip("Intensity multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
        public ClampedFloatParameter xMultiplier;
        [Tooltip("Intensity multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
        public ClampedFloatParameter yMultiplier;
        [Tooltip("Distortion center point. 0.5,0.5 is center of the screen")]
        public Vector2Parameter center;
        [Tooltip("Controls global screen scaling for the distortion effect. Use this to hide screen borders when using high \"Intensity.\"")]
        public ClampedFloatParameter scale;

        public LensDistortion();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
