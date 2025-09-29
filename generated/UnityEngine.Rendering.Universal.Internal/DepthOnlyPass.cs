#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal.Internal
{
    public class DepthOnlyPass : ScriptableRenderPass
    {
        public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask);

        public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle);
        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData);
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void OnCameraCleanup(CommandBuffer cmd);
    }
}
