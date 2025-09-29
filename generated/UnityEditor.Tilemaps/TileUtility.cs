#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Tilemaps;

namespace UnityEditor.Tilemaps
{
    public class TileUtility
    {
        public TileUtility();

        public static Tile CreateDefaultTile();
        [CreateTileFromPalette]
        public static TileBase DefaultTile(Sprite sprite);
    }
}
