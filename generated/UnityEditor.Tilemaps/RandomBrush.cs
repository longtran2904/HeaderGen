#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Tilemaps;

namespace UnityEditor.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Brushes/Random Brush", fileName = "New Random Brush", order = 84)]
    [CustomGridBrush(False, False, False, "Random Brush")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RandomBrush.html")]
    public class RandomBrush : GridBrush
    {
        public Vector3Int randomTileSetSize;
        public RandomTileSet[] randomTileSets;
        public bool pickRandomTiles;
        public bool addToRandomTiles;

        public RandomBrush();

        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt bounds, Vector3Int pickStart);

        public struct RandomTileSet
        {
            public TileBase[] randomTiles;
        }
    }
}
