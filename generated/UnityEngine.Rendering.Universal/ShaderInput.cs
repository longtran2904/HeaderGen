#region Unity.RenderPipeline.Universal.ShaderLibrary, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipeline.Universal.ShaderLibrary.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    public static class ShaderInput
    {
        [Obsolete("ShaderInput.ShadowData was deprecated. Shadow slice matrices and per-light shadow parameters are now passed to the GPU using entries in buffers m_AdditionalLightsWorldToShadow_SSBO and m_AdditionalShadowParams_SSBO", False)]
        public struct ShadowData
        {
            public Matrix4x4 worldToShadowMatrix;
            public Vector4 shadowParams;
        }
        [GenerateHLSL(PackingRules.Exact, False, False, False, 1, False, False, False, -1, "D:\\Documents\\GitHub\\Rogue-like-game-i-guess\\The game is liar\\Library\\PackageCache\\com.unity.render-pipelines.universal@12.1.14\\ShaderLibrary\\ShaderTypes.cs")]
        public struct LightData
        {
            public Vector4 position;
            public Vector4 color;
            public Vector4 attenuation;
            public Vector4 spotDirection;
            public Vector4 occlusionProbeChannels;
            public uint layerMask;
        }
    }
}
