#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Tilemaps;

namespace UnityEditor
{
    [CustomEditor(typeof(AdvancedRuleOverrideTile))]
    public class AdvancedRuleOverrideTileEditor : RuleOverrideTileEditor
    {
        public AdvancedRuleOverrideTileEditor();

        public AdvancedRuleOverrideTile overrideTile { get; }

        public override void OnEnable();
        public override void OnInspectorGUI();
        public void DrawRulesHeader(Rect rect);
        public void DrawRuleElement(Rect rect, int index, bool active, bool focused);
        public void DrawRule(Rect rect, RuleTile.TilingRuleOutput rule, bool isOverride, RuleTile.TilingRule originalRule, bool isMissing);
        public float GetRuleElementHeight(int index);
    }
}
