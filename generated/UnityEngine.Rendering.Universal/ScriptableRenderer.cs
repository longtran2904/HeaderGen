#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.Rendering.Universal
{
    public abstract class ScriptableRenderer : IDisposable
    {

        public ScriptableRenderer(ScriptableRendererData data);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("cameraDepth has been renamed to cameraDepthTarget. (UnityUpgradable) -> cameraDepthTarget")]
        public RenderTargetIdentifier cameraDepth { get; }
        protected ProfilingSampler profilingExecute { get; set; }
        public RenderTargetIdentifier cameraColorTarget { get; }
        public RenderTargetIdentifier cameraDepthTarget { get; }
        protected List<ScriptableRendererFeature> rendererFeatures { get; }
        protected List<ScriptableRenderPass> activeRenderPassQueue { get; }
        public RenderingFeatures supportedRenderingFeatures { get; set; }
        public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }

        public virtual int SupportedCameraStackingTypes();
        public bool SupportsCameraStackingType(CameraRenderType cameraRenderType);
        public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget);
        public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData);
        public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData);
        public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData);
        public virtual void FinishRendering(CommandBuffer cmd);
        public void Execute(ScriptableRenderContext context, ref RenderingData renderingData);
        public void EnqueuePass(ScriptableRenderPass pass);
        protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData);
        protected void AddRenderPasses(ref RenderingData renderingData);
        public class RenderingFeatures
        {

            public RenderingFeatures();

            [Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead.", False)]
            public bool cameraStacking { get; set; }
            public bool msaa { get; set; }
        }
    }
}
