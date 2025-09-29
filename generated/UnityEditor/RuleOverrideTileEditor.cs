#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace UnityEditor
{
    [CustomEditor(typeof(RuleOverrideTile))]
    public class RuleOverrideTileEditor : Editor
    {

        public List<KeyValuePair<Sprite, Sprite>> m_Sprites;
        public List<KeyValuePair<GameObject, GameObject>> m_GameObjects;
        public static float k_SpriteElementHeight;
        public static float k_GameObjectElementHeight;
        public static float k_PaddingBetweenRules;

        public RuleOverrideTileEditor();

        public RuleOverrideTile overrideTile { get; }
        public RuleTileEditor ruleTileEditor { get; }

        public virtual void OnEnable();
        public virtual void OnDisable();
        public override void OnInspectorGUI();
        public void DrawSpriteListHeader(Rect rect);
        public void DrawGameObjectListHeader(Rect rect);
        public float GetSpriteElementHeight(int index);
        public float GetGameObjectElementHeight(int index);
        public void DrawSpriteElement(Rect rect, int index, bool active, bool focused);
        public void DrawGameObjectElement(Rect rect, int index, bool active, bool focused);
        public void DrawTileField();
        public void DrawCustomFields();
        public void SaveTile();
        public override Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height);
        public override bool HasPreviewGUI();
        public override void OnPreviewSettings();
        public override void OnPreviewGUI(Rect rect, GUIStyle background);
    }
}
