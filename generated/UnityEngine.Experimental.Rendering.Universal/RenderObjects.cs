#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
    [ExcludeFromPreset]
    [Tooltip("Render Objects simplifies the injection of additional render passes by exposing a selection of commonly used settings.")]
    public class RenderObjects : ScriptableRendererFeature
    {

        public RenderObjectsSettings settings;

        public RenderObjects();

        public override void Create();
        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);
        public class RenderObjectsSettings
        {

            public string passTag;
            public RenderPassEvent Event;
            public FilterSettings filterSettings;
            public Material overrideMaterial;
            public int overrideMaterialPassIndex;
            public bool overrideDepthState;
            public CompareFunction depthCompareFunction;
            public bool enableWrite;
            public StencilStateData stencilSettings;
            public CustomCameraSettings cameraSettings;

            public RenderObjectsSettings();
        }
        public class FilterSettings
        {

            public RenderQueueType RenderQueueType;
            public LayerMask LayerMask;
            public string[] PassNames;

            public FilterSettings();
        }
        public class CustomCameraSettings
        {

            public bool overrideCamera;
            public bool restoreCamera;
            public Vector4 offset;
            public float cameraFieldOfView;

            public CustomCameraSettings();
        }
    }
}
