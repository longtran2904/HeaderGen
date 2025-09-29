#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

namespace UnityEditor.ShaderGraph.Internal
{
    public static class CoordinateSpaceExtensions
    {
        public static string ToVariableName(this CoordinateSpace space, InterpolatorType type);
        public static NeededCoordinateSpace ToNeededCoordinateSpace(this CoordinateSpace space);
        public static CoordinateSpace ToCoordinateSpace(this NeededCoordinateSpace space);
    }
}
