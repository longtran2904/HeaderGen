#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public abstract class FlipTool : TilemapEditorTool
    {

        protected FlipTool();

        protected void Flip(GridBrushBase.FlipAxis axis);
        public override void OnToolGUI(EditorWindow window);
    }
}
