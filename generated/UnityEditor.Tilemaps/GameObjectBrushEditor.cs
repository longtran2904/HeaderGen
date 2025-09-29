#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomEditor(typeof(GameObjectBrush))]
    public class GameObjectBrushEditor : GridBrushEditorBase
    {

        public GameObjectBrushEditor();

        public GameObjectBrush brush { get; }
        public override GameObject[] validTargets { get; }

        public override void OnPaintSceneGUI(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, GridBrushBase.Tool tool, bool executing);
        public override void OnPaintInspectorGUI();
    }
}
