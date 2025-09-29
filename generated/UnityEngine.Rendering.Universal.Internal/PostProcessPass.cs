#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal.Internal
{
    public class PostProcessPass : ScriptableRenderPass
    {
        public PostProcessPass(RenderPassEvent evt, PostProcessData data, Material blitMaterial);

        public void Cleanup();
        public void Setup(in RenderTextureDescriptor baseDescriptor, in RenderTargetHandle source, bool resolveToScreen, in RenderTargetHandle depth, in RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion);
        public void Setup(in RenderTextureDescriptor baseDescriptor, in RenderTargetHandle source, RenderTargetHandle destination, in RenderTargetHandle depth, in RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion);
        public void SetupFinalPass(in RenderTargetHandle source, bool useSwapBuffer = False);
        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData);
        public override void OnCameraCleanup(CommandBuffer cmd);
        public void ResetHistory();
        public bool CanRunOnTile();
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
    }
}
