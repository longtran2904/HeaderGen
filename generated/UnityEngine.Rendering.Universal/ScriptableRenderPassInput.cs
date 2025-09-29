#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    [Flags]
    public enum ScriptableRenderPassInput
    {
        None = 0,
        Depth = 1,
        Normal = 2,
        Color = 4,
        Motion = 8
    }
}
