#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;

namespace UnityEditor.ShaderGraph.Internal
{
    [Flags]
    public enum NeededCoordinateSpace
    {
        None = 0,
        Object = 1,
        View = 2,
        World = 4,
        Tangent = 8,
        AbsoluteWorld = 16
    }
}
