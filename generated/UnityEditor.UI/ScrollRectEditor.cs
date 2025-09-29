#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ScrollRect), True)]
    public class ScrollRectEditor : Editor
    {
        public ScrollRectEditor();

        protected virtual void OnEnable();
        protected virtual void OnDisable();
        public override void OnInspectorGUI();
    }
}
