#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public sealed class UniversalRenderer : ScriptableRenderer
    {
        public UniversalRenderer(UniversalRendererData data);

        public DepthPrimingMode depthPrimingMode { get; set; }

        public override int SupportedCameraStackingTypes();
        protected override void Dispose(bool disposing);
        public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData);
        public override void FinishRendering(CommandBuffer cmd);
    }
}
