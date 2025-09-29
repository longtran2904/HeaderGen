#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CustomEditor(typeof(Selectable), True)]
    public class SelectableEditor : Editor
    {

        public SelectableEditor();

        protected virtual void OnEnable();
        protected virtual void OnDisable();
        public override void OnInspectorGUI();
    }
}
