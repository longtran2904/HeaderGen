#region Unity.RenderPipeline.Universal.ShaderLibrary, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipeline.Universal.ShaderLibrary.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    [Flags]
    [GenerateHLSL(PackingRules.Exact, True, False, False, 1, False, False, False, -1, "D:\\Documents\\GitHub\\Rogue-like-game-i-guess\\The game is liar\\Library\\PackageCache\\com.unity.render-pipelines.universal@12.1.14\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
    public enum DebugLightingFeatureFlags
    {

        None = 0,
        GlobalIllumination = 1,
        MainLight = 2,
        AdditionalLights = 4,
        VertexLighting = 8,
        Emission = 16,
        AmbientOcclusion = 32
    }
}
