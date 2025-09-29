#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.Tilemaps
{
    [CustomEditor(typeof(GridBrush))]
    [MovedFrom(True, "UnityEditor", "UnityEditor", null)]
    public class GridBrushEditor : GridBrushEditorBase
    {

        public GridBrushEditor();

        public GridBrush brush { get; }
        public override bool canChangeZPosition { get; set; }
        public override GameObject[] validTargets { get; }

        protected virtual void OnEnable();
        protected virtual void OnDisable();
        public override void OnPaintSceneGUI(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, GridBrushBase.Tool tool, bool executing);
        public override void OnSelectionInspectorGUI();
        public override void OnSelectionSceneGUI(GridLayout gridLayout, GameObject brushTarget);
        public override void OnMouseLeave();
        public override void OnToolDeactivated(GridBrushBase.Tool tool);
        public override void RegisterUndo(GameObject brushTarget, GridBrushBase.Tool tool);
        public virtual void PaintPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public virtual void BoxFillPreview(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public virtual void FloodFillPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public virtual void ClearPreview();
        public enum ModifyCells
        {

            InsertRow = 0,
            InsertColumn = 1,
            InsertRowBefore = 2,
            InsertColumnBefore = 3,
            DeleteRow = 4,
            DeleteColumn = 5,
            DeleteRowBefore = 6,
            DeleteColumnBefore = 7
        }
    }
}
