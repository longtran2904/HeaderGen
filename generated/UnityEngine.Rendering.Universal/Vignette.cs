#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Vignette", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class Vignette : VolumeComponent, IPostProcessComponent
    {
        [Tooltip("Vignette color.")]
        public ColorParameter color;
        [Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
        public Vector2Parameter center;
        [Tooltip("Amount of vignetting on screen.")]
        public ClampedFloatParameter intensity;
        [Tooltip("Smoothness of the vignette borders.")]
        public ClampedFloatParameter smoothness;
        [Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
        public BoolParameter rounded;

        public Vignette();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
