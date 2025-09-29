#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    [Obsolete("ForwardRenderer has been deprecated (UnityUpgradable) -> UniversalRenderer", True)]
    public sealed class ForwardRenderer : ScriptableRenderer
    {
        public ForwardRenderer(ForwardRendererData data);

        public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData);
        public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData);
        public override void FinishRendering(CommandBuffer cmd);
    }
}
