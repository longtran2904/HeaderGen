#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Brushes/Prefab Brush", fileName = "New Prefab Brush", order = 84)]
    [CustomGridBrush(False, True, False, "Prefab Brush")]
    public class PrefabBrush : BasePrefabBrush
    {

        public PrefabBrush();

        public override void Rotate(RotationDirection direction, GridLayout.CellLayout layout);
        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void BoxFill(GridLayout grid, GameObject brushTarget, BoundsInt bounds);
        public override void Erase(GridLayout grid, GameObject brushTarget, Vector3Int position);
        [CustomEditor(typeof(PrefabBrush))]
        public class PrefabBrushEditor : BasePrefabBrushEditor
        {

            public PrefabBrushEditor();

            protected override void OnEnable();
            public override void OnPaintInspectorGUI();
        }
    }
}
