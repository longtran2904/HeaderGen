#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

namespace UnityEditor.Tilemaps
{
    public class BasePrefabBrushEditor : GridBrushEditor
    {
        protected SerializedObject m_SerializedObject;

        public BasePrefabBrushEditor();

        protected override void OnEnable();
        public override void OnPaintInspectorGUI();
    }
}
