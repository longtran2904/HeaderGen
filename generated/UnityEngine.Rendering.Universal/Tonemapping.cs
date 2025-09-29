#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Tonemapping", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class Tonemapping : VolumeComponent, IPostProcessComponent
    {

        [Tooltip("Select a tonemapping algorithm to use for the color grading process.")]
        public TonemappingModeParameter mode;

        public Tonemapping();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
