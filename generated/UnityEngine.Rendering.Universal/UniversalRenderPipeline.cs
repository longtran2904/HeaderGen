#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
    public sealed class UniversalRenderPipeline : RenderPipeline
    {
        public const string k_ShaderTagName = "UniversalPipeline";

        public UniversalRenderPipeline(UniversalRenderPipelineAsset asset);

        public static float maxShadowBias { get; }
        public static float minRenderScale { get; }
        public static float maxRenderScale { get; }
        public static int maxPerObjectLights { get; }
        public static int maxVisibleAdditionalLights { get; }
        public override RenderPipelineGlobalSettings defaultSettings { get; }
        public static UniversalRenderPipelineAsset asset { get; }

        public override string ToString();
        protected override void Dispose(bool disposing);
        protected override void Render(ScriptableRenderContext renderContext, Camera[] cameras);
        protected override void Render(ScriptableRenderContext renderContext, List<Camera> cameras);
        public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera);
        public static bool IsGameCamera(Camera camera);
        [Obsolete("Please use CameraData.xr.enabled instead.")]
        public static bool IsStereoEnabled(Camera camera);
        public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, float? innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir);
        public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel);
    }
}
