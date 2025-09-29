#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(HexagonalRuleTile), True)]
    public class HexagonalRuleTileEditor : RuleTileEditor
    {
        public HexagonalRuleTileEditor();

        public HexagonalRuleTile hexTile { get; }

        public override int GetArrowIndex(Vector3Int position);
        public override BoundsInt GetRuleGUIBounds(BoundsInt bounds, RuleTile.TilingRule rule);
        public override Vector2 GetMatrixSize(BoundsInt bounds);
        public override void RuleMatrixOnGUI(RuleTile tile, Rect rect, BoundsInt bounds, RuleTile.TilingRule tilingRule);
        protected override void CreatePreview();
    }
}
