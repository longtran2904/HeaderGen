#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public abstract class RenderPipeline
    {

        protected RenderPipeline();

        public bool disposed { get; }
        public virtual RenderPipelineGlobalSettings defaultSettings { get; }

        protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);
        protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests);
        protected static void BeginFrameRendering(ScriptableRenderContext context, Camera[] cameras);
        protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras);
        protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera);
        protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras);
        protected static void EndFrameRendering(ScriptableRenderContext context, Camera[] cameras);
        protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera);
        protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras);
        protected virtual void Dispose(bool disposing);
    }
}
