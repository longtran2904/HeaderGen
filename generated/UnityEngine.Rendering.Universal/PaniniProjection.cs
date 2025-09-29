#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Panini Projection", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
    {
        [Tooltip("Panini projection distance.")]
        public ClampedFloatParameter distance;
        [Tooltip("Panini projection crop to fit.")]
        public ClampedFloatParameter cropToFit;

        public PaniniProjection();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
