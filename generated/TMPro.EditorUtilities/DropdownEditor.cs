#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEditor.UI;

namespace TMPro.EditorUtilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TMP_Dropdown), True)]
    public class DropdownEditor : SelectableEditor
    {

        public DropdownEditor();

        protected override void OnEnable();
        public override void OnInspectorGUI();
    }
}
