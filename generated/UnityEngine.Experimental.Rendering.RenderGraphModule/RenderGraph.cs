#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public class RenderGraph
    {

        public static readonly int kMaxMRTCount;

        public RenderGraph(string name = "RenderGraph");

        public string name { get; }
        public RenderGraphDefaultResources defaultResources { get; }

        public void Cleanup();
        public void RegisterDebug(DebugUI.Panel panel = null);
        public void UnRegisterDebug();
        public static List<RenderGraph> GetRegisteredRenderGraphs();
        public void EndFrame();
        public TextureHandle ImportTexture(RTHandle rt);
        public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt);
        public TextureHandle CreateTexture(in TextureDesc desc);
        public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = False);
        public void ReleaseSharedTexture(TextureHandle texture);
        public TextureHandle CreateTexture(TextureHandle texture);
        public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture);
        public TextureDesc GetTextureDesc(TextureHandle texture);
        public RendererListHandle CreateRendererList(in UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
        public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer);
        public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc);
        public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer);
        public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer);
        public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) where PassData : class, new();
        public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) where PassData : class, new();
        public RenderGraphExecution RecordAndExecute(in RenderGraphParameters parameters);
        public void BeginProfilingSampler(ProfilingSampler sampler);
        public void EndProfilingSampler(ProfilingSampler sampler);
    }
}
