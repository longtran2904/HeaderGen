#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.Tilemaps
{
    [CustomEditor(typeof(GridBrushBase))]
    [MovedFrom(True, "UnityEditor", "UnityEditor", null)]
    public class GridBrushEditorBase : Editor
    {

        public GridBrushEditorBase();

        public virtual bool canChangeZPosition { get; set; }
        public virtual GameObject[] validTargets { get; }

        public virtual void OnPaintSceneGUI(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, GridBrushBase.Tool tool, bool executing);
        public virtual void OnPaintInspectorGUI();
        public virtual void OnSelectionInspectorGUI();
        public virtual void OnSelectionSceneGUI(GridLayout gridLayout, GameObject brushTarget);
        public virtual void OnSceneGUI(GridLayout gridLayout, GameObject brushTarget);
        public virtual void OnMouseLeave();
        public virtual void OnMouseEnter();
        public virtual void OnToolActivated(GridBrushBase.Tool tool);
        public virtual void OnToolDeactivated(GridBrushBase.Tool tool);
        public virtual void RegisterUndo(GameObject brushTarget, GridBrushBase.Tool tool);
    }
}
