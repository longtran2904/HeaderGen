#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Channel Mixer", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent
    {

        [Tooltip("Modify influence of the red channel in the overall mix.")]
        public ClampedFloatParameter redOutRedIn;
        [Tooltip("Modify influence of the green channel in the overall mix.")]
        public ClampedFloatParameter redOutGreenIn;
        [Tooltip("Modify influence of the blue channel in the overall mix.")]
        public ClampedFloatParameter redOutBlueIn;
        [Tooltip("Modify influence of the red channel in the overall mix.")]
        public ClampedFloatParameter greenOutRedIn;
        [Tooltip("Modify influence of the green channel in the overall mix.")]
        public ClampedFloatParameter greenOutGreenIn;
        [Tooltip("Modify influence of the blue channel in the overall mix.")]
        public ClampedFloatParameter greenOutBlueIn;
        [Tooltip("Modify influence of the red channel in the overall mix.")]
        public ClampedFloatParameter blueOutRedIn;
        [Tooltip("Modify influence of the green channel in the overall mix.")]
        public ClampedFloatParameter blueOutGreenIn;
        [Tooltip("Modify influence of the blue channel in the overall mix.")]
        public ClampedFloatParameter blueOutBlueIn;

        public ChannelMixer();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
