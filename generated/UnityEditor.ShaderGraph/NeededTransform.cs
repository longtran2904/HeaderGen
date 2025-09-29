#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEditor.ShaderGraph.Internal;

namespace UnityEditor.ShaderGraph
{
    public struct NeededTransform
    {
        public NeededCoordinateSpace from;
        public NeededCoordinateSpace to;

        public NeededTransform(NeededCoordinateSpace from, NeededCoordinateSpace to);

        public static NeededTransform None { get; }
        public static NeededTransform ObjectToWorld { get; }
        public static NeededTransform WorldToObject { get; }
    }
}
