#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(RuleTile), True)]
    public class RuleTileEditor : Editor
    {
        public bool extendNeighbor;
        public PreviewRenderUtility m_PreviewUtility;
        public Grid m_PreviewGrid;
        public List<Tilemap> m_PreviewTilemaps;
        public List<TilemapRenderer> m_PreviewTilemapRenderers;
        public const float k_DefaultElementHeight = 48;
        public const float k_PaddingBetweenRules = 26;
        public const float k_SingleLineHeight = 16;
        public const float k_LabelWidth = 80;

        public RuleTileEditor();

        public static Texture2D[] arrows { get; }
        public static Texture2D[] autoTransforms { get; }
        public RuleTile tile { get; }

        public virtual void OnEnable();
        public virtual void OnDisable();
        public virtual BoundsInt GetRuleGUIBounds(BoundsInt bounds, RuleTile.TilingRule rule);
        public void ListUpdated(ReorderableList list);
        public float GetElementHeight(RuleTile.TilingRule rule);
        public float GetElementHeight(RuleTile.TilingRuleOutput rule);
        public virtual Vector2 GetMatrixSize(BoundsInt bounds);
        protected virtual void OnDrawElement(Rect rect, int index, bool isactive, bool isfocused);
        public void SaveTile();
        public static void UpdateAffectedOverrideTiles(RuleTile target);
        public static List<RuleOverrideTile> FindAffectedOverrideTiles(RuleTile target);
        public void OnDrawHeader(Rect rect);
        public override void OnInspectorGUI();
        public void DrawCustomFields(bool isOverrideInstance);
        public virtual int GetArrowIndex(Vector3Int position);
        public virtual void RuleOnGUI(Rect rect, Vector3Int position, int neighbor);
        public void RuleTooltipOnGUI(Rect rect, int neighbor);
        public virtual void RuleTransformOnGUI(Rect rect, RuleTile.TilingRuleOutput.Transform ruleTransform);
        public void RuleNeighborUpdate(Rect rect, RuleTile.TilingRule tilingRule, Dictionary<Vector3Int, int> neighbors, Vector3Int position);
        public void RuleTransformUpdate(Rect rect, RuleTile.TilingRule tilingRule);
        public virtual bool ContainsMousePosition(Rect rect);
        public static int GetMouseChange();
        public virtual void RuleMatrixOnGUI(RuleTile tile, Rect rect, BoundsInt bounds, RuleTile.TilingRule tilingRule);
        public void RuleMatrixIconOnGUI(RuleTile.TilingRule tilingRule, Dictionary<Vector3Int, int> neighbors, Vector3Int position, Rect rect);
        public virtual void SpriteOnGUI(Rect rect, RuleTile.TilingRuleOutput tilingRule);
        public void RuleInspectorOnGUI(Rect rect, RuleTile.TilingRuleOutput tilingRule);
        public override bool HasPreviewGUI();
        public override void OnPreviewGUI(Rect rect, GUIStyle background);
        protected virtual void CreatePreview();
        protected virtual void DestroyPreview();
        public override Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height);
        public static Texture2D Base64ToTexture(string base64);
        [MenuItem("CONTEXT/RuleTile/Copy All Rules")]
        public static void CopyAllRules(MenuCommand item);
        [MenuItem("CONTEXT/RuleTile/Paste Rules")]
        public static void PasteRules(MenuCommand item);
    }
}
