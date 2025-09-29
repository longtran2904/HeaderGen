#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public abstract class RotateTool : TilemapEditorTool
    {
        protected RotateTool();

        protected void Rotate(GridBrushBase.RotationDirection direction);
        public override void OnToolGUI(EditorWindow window);
    }
}
