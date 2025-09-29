#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    [VolumeComponentMenuForRenderPipeline("Post-processing/Color Curves", new[] {typeof(UniversalRenderPipeline) })]
    public sealed class ColorCurves : VolumeComponent, IPostProcessComponent
    {

        public TextureCurveParameter master;
        public TextureCurveParameter red;
        public TextureCurveParameter green;
        public TextureCurveParameter blue;
        public TextureCurveParameter hueVsHue;
        public TextureCurveParameter hueVsSat;
        public TextureCurveParameter satVsSat;
        public TextureCurveParameter lumVsSat;

        public ColorCurves();

        public bool IsActive();
        public bool IsTileCompatible();
    }
}
