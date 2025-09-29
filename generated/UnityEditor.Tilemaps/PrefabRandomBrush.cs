#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Brushes/Prefab Random Brush", fileName = "New Prefab Random Brush", order = 84)]
    [CustomGridBrush(False, True, False, "Prefab Random Brush")]
    public class PrefabRandomBrush : BasePrefabBrush
    {
        public PrefabRandomBrush();

        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void Erase(GridLayout grid, GameObject brushTarget, Vector3Int position);

        [CustomEditor(typeof(PrefabRandomBrush))]
        public class PrefabRandomBrushEditor : BasePrefabBrushEditor
        {
            public PrefabRandomBrushEditor();

            protected override void OnEnable();
            public override void OnPaintInspectorGUI();
        }
    }
}
