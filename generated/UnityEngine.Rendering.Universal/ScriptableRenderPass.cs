#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.Rendering.Universal
{
    public abstract class ScriptableRenderPass
    {

        public ScriptableRenderPass();

        public RenderPassEvent renderPassEvent { get; set; }
        public RenderTargetIdentifier[] colorAttachments { get; }
        public RenderTargetIdentifier colorAttachment { get; }
        public RenderTargetIdentifier depthAttachment { get; }
        public RenderBufferStoreAction[] colorStoreActions { get; }
        public RenderBufferStoreAction depthStoreAction { get; }
        public ScriptableRenderPassInput input { get; }
        public ClearFlag clearFlag { get; }
        public Color clearColor { get; }
        protected internal ProfilingSampler profilingSampler { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual void FrameCleanup(CommandBuffer cmd);
        public void ConfigureInput(ScriptableRenderPassInput passInput);
        public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0);
        public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions);
        public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction);
        public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment);
        public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment);
        public void ConfigureTarget(RenderTargetIdentifier colorAttachment);
        public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments);
        public void ConfigureClear(ClearFlag clearFlag, Color clearColor);
        public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData);
        public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor);
        public virtual void OnCameraCleanup(CommandBuffer cmd);
        public virtual void OnFinishCameraStackRendering(CommandBuffer cmd);
        public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
        public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0);
        public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0);
        public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria);
        public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria);

        public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs);
        public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs);
    }
}
