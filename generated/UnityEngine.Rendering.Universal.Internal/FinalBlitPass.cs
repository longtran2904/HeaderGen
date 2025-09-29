#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal.Internal
{
    public class FinalBlitPass : ScriptableRenderPass
    {

        public FinalBlitPass(RenderPassEvent evt, Material blitMaterial);

        public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle);
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
    }
}
