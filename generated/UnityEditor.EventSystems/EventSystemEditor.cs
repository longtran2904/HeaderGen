#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityEditor.EventSystems
{
    [CustomEditor(typeof(EventSystem), True)]
    public class EventSystemEditor : Editor
    {
        public EventSystemEditor();

        protected GUIStyle previewLabelStyle { get; }

        public override void OnInspectorGUI();
        public override bool HasPreviewGUI();
        public override bool RequiresConstantRepaint();
        public override void OnPreviewGUI(Rect rect, GUIStyle background);
    }
}
