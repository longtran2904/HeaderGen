#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal.Internal
{
    public class MainLightShadowCasterPass : ScriptableRenderPass
    {
        public MainLightShadowCasterPass(RenderPassEvent evt);

        public bool Setup(ref RenderingData renderingData);
        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor);
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void OnCameraCleanup(CommandBuffer cmd);
    }
}
