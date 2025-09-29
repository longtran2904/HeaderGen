#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Rendering
{
    public struct RenderTargetBinding
    {
        public RenderTargetBinding(RenderTargetIdentifier[] colorRenderTargets, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderTargetIdentifier depthRenderTarget, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction);
        public RenderTargetBinding(RenderTargetIdentifier colorRenderTarget, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthRenderTarget, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction);
        public RenderTargetBinding(RenderTargetSetup setup);

        public RenderTargetIdentifier[] colorRenderTargets { get; set; }
        public RenderTargetIdentifier depthRenderTarget { get; set; }
        public RenderBufferLoadAction[] colorLoadActions { get; set; }
        public RenderBufferStoreAction[] colorStoreActions { get; set; }
        public RenderBufferLoadAction depthLoadAction { get; set; }
        public RenderBufferStoreAction depthStoreAction { get; set; }
        public RenderTargetFlags flags { get; set; }
    }
}
