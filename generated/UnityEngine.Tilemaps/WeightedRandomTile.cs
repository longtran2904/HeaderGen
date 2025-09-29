#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

namespace UnityEngine.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Tiles/Weighted Random Tile", fileName = "New Weighted Random Tile", order = 82)]
    public class WeightedRandomTile : Tile
    {
        [SerializeField]
        public WeightedSprite[] Sprites;

        public WeightedRandomTile();

        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
    }
}
