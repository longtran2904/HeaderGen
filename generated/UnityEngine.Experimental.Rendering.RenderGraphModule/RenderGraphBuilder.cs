#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public struct RenderGraphBuilder : IDisposable
    {

        public TextureHandle UseColorBuffer(in TextureHandle input, int index);
        public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags);
        public TextureHandle ReadTexture(in TextureHandle input);
        public TextureHandle WriteTexture(in TextureHandle input);
        public TextureHandle ReadWriteTexture(in TextureHandle input);
        public TextureHandle CreateTransientTexture(in TextureDesc desc);
        public TextureHandle CreateTransientTexture(in TextureHandle texture);
        public RendererListHandle UseRendererList(in RendererListHandle input);
        public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input);
        public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input);
        public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc);
        public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer);
        public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new();
        public void EnableAsyncCompute(bool value);
        public void AllowPassCulling(bool value);
        public void Dispose();
        public void AllowRendererListCulling(bool value);
        public RendererListHandle DependsOn(in RendererListHandle input);
    }
}
