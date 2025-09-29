#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Button), True)]
    public class ButtonEditor : SelectableEditor
    {

        public ButtonEditor();

        protected override void OnEnable();
        public override void OnInspectorGUI();
    }
}
