#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Split Toning", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class SplitToning : VolumeComponent, IPostProcessComponent
    {
        [Tooltip("The color to use for shadows.")]
        public ColorParameter shadows;
        [Tooltip("The color to use for highlights.")]
        public ColorParameter highlights;
        [Tooltip("Balance between the colors in the highlights and shadows.")]
        public ClampedFloatParameter balance;

        public SplitToning();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
