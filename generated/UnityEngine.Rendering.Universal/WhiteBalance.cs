#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/White Balance", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
    {
        [Tooltip("Sets the white balance to a custom color temperature.")]
        public ClampedFloatParameter temperature;
        [Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
        public ClampedFloatParameter tint;

        public WhiteBalance();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
