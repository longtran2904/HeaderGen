#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
    public struct LightData
    {

        public int mainLightIndex;
        public int additionalLightsCount;
        public int maxPerObjectAdditionalLightsCount;
        public NativeArray<VisibleLight> visibleLights;
        public bool shadeAdditionalLightsPerVertex;
        public bool supportsMixedLighting;
        public bool reflectionProbeBoxProjection;
        public bool reflectionProbeBlending;
        public bool supportsLightLayers;
        public bool supportsAdditionalLights;
    }
}
