#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    [ExcludeFromPreset]
    [Obsolete("ForwardRendererData has been deprecated (UnityUpgradable) -> UniversalRendererData", True)]
    [ReloadGroup]
    public class ForwardRendererData : ScriptableRendererData
    {

        public ShaderResources shaders;
        public PostProcessData postProcessData;
        [Reload("Runtime/Data/XRSystemData.asset", ReloadAttribute.Package.Root)]
        public XRSystemData xrSystemData;

        public ForwardRendererData();

        public LayerMask opaqueLayerMask { get; set; }
        public LayerMask transparentLayerMask { get; set; }
        public StencilStateData defaultStencilState { get; set; }
        public bool shadowTransparentReceive { get; set; }
        public RenderingMode renderingMode { get; set; }
        public bool accurateGbufferNormals { get; set; }

        protected override ScriptableRenderer Create();
        [ReloadGroup]
        public sealed class ShaderResources
        {

            [Reload("Shaders/Utils/Blit.shader", ReloadAttribute.Package.Root)]
            public Shader blitPS;
            [Reload("Shaders/Utils/CopyDepth.shader", ReloadAttribute.Package.Root)]
            public Shader copyDepthPS;
            [Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature")]
            public Shader screenSpaceShadowPS;
            [Reload("Shaders/Utils/Sampling.shader", ReloadAttribute.Package.Root)]
            public Shader samplingPS;
            [Reload("Shaders/Utils/StencilDeferred.shader", ReloadAttribute.Package.Root)]
            public Shader stencilDeferredPS;
            [Reload("Shaders/Utils/FallbackError.shader", ReloadAttribute.Package.Root)]
            public Shader fallbackErrorPS;
            [Reload("Shaders/Utils/MaterialError.shader", ReloadAttribute.Package.Root)]
            public Shader materialErrorPS;
            [Reload("Shaders/CameraMotionVectors.shader", ReloadAttribute.Package.Root)]
            public Shader cameraMotionVector;
            [Reload("Shaders/ObjectMotionVectors.shader", ReloadAttribute.Package.Root)]
            public Shader objectMotionVector;

            public ShaderResources();
        }
    }
}
