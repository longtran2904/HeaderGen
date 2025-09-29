#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public static class RenderPipelineManager
    {
        public static RenderPipeline currentPipeline { get; }
        public static bool pipelineSwitchCompleted { get; }

        public static event Action<ScriptableRenderContext, List<Camera>> beginContextRendering;
        public static event Action<ScriptableRenderContext, List<Camera>> endContextRendering;
        public static event Action<ScriptableRenderContext, Camera[]> beginFrameRendering;
        public static event Action<ScriptableRenderContext, Camera> beginCameraRendering;
        public static event Action<ScriptableRenderContext, Camera[]> endFrameRendering;
        public static event Action<ScriptableRenderContext, Camera> endCameraRendering;
        public static event Action activeRenderPipelineTypeChanged;
        public static event Action activeRenderPipelineCreated;
        public static event Action activeRenderPipelineDisposed;
    }
}
