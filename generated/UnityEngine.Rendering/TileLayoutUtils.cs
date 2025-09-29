#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class TileLayoutUtils
    {

        public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight);
        public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other);
        public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other);
    }
}
