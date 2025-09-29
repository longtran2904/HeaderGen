#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal.Internal
{
    public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
    {

        [Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", False)]
        public static int m_AdditionalShadowsBufferId;
        [Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", False)]
        public static int m_AdditionalShadowsIndicesId;

        public AdditionalLightsShadowCasterPass(RenderPassEvent evt);

        public bool Setup(ref RenderingData renderingData);
        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor);
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void OnCameraCleanup(CommandBuffer cmd);
        public int GetShadowLightIndexFromLightIndex(int visibleLightIndex);
    }
}
