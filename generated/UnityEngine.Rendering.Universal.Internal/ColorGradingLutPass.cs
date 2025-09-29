#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal.Internal
{
    public class ColorGradingLutPass : ScriptableRenderPass
    {
        public ColorGradingLutPass(RenderPassEvent evt, PostProcessData data);

        public void Setup(in RenderTargetHandle internalLut);
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void OnFinishCameraStackRendering(CommandBuffer cmd);
        public void Cleanup();
    }
}
