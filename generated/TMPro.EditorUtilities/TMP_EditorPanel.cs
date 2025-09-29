#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro.EditorUtilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TextMeshPro), True)]
    public class TMP_EditorPanel : TMP_BaseEditorPanel
    {

        public TMP_EditorPanel();

        protected override void OnEnable();
        protected override void DrawExtraSettings();
        protected void DrawVolumetricSetup();
        protected override bool IsMixSelectionTypes();
        protected override void OnUndoRedo();
    }
}
