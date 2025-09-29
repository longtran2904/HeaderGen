#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(IsometricRuleTile), True)]
    public class IsometricRuleTileEditor : RuleTileEditor
    {

        public IsometricRuleTileEditor();

        public override int GetArrowIndex(Vector3Int position);
        public override Vector2 GetMatrixSize(BoundsInt bounds);
        public override void RuleMatrixOnGUI(RuleTile tile, Rect rect, BoundsInt bounds, RuleTile.TilingRule tilingRule);
        public override bool ContainsMousePosition(Rect rect);
        public override void OnPreviewSettings();
        protected override void CreatePreview();
    }
}
