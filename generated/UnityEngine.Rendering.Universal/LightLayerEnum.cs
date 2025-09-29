#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    [Flags]
    public enum LightLayerEnum
    {
        Nothing = 0,
        LightLayerDefault = 1,
        LightLayer1 = 2,
        LightLayer2 = 4,
        LightLayer3 = 8,
        LightLayer4 = 16,
        LightLayer5 = 32,
        LightLayer6 = 64,
        LightLayer7 = 128,
        Everything = 255
    }
}
