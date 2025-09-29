#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

namespace UnityEngine
{
    [CreateAssetMenu(menuName = "2D/Tiles/Hexagonal Rule Tile", fileName = "New Hexagonal Rule Tile", order = 83)]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleTile.html")]
    public class HexagonalRuleTile : RuleTile
    {

        [DontOverride]
        public bool m_FlatTop;

        public HexagonalRuleTile();

        public override int m_RotationAngle { get; }

        public static Vector3 TilemapPositionToWorldPosition(Vector3Int tilemapPosition);
        public static Vector3Int WorldPositionToTilemapPosition(Vector3 worldPosition);
        public override Vector3Int GetOffsetPosition(Vector3Int position, Vector3Int offset);
        public override Vector3Int GetOffsetPositionReverse(Vector3Int position, Vector3Int offset);
        public override Vector3Int GetRotatedPosition(Vector3Int position, int rotation);
        public override Vector3Int GetMirroredPosition(Vector3Int position, bool mirrorX, bool mirrorY);
    }
}
