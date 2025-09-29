#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public enum DynamicResUpscaleFilter
    {

        [Obsolete("Bilinear upscale filter is considered obsolete and is not supported anymore, please use CatmullRom for a very cheap, but blurry filter.", False)]
        Bilinear = 0,
        CatmullRom = 1,
        [Obsolete("Lanczos upscale filter is considered obsolete and is not supported anymore, please use Contrast Adaptive Sharpening for very sharp filter or FidelityFX Super Resolution 1.0.", False)]
        Lanczos = 2,
        ContrastAdaptiveSharpen = 3,
        [InspectorName("FidelityFX Super Resolution 1.0")]
        EdgeAdaptiveScalingUpres = 4,
        [InspectorName("TAA Upscale")]
        TAAU = 5
    }
}
