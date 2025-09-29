#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(RawImage), True)]
    public class RawImageEditor : GraphicEditor
    {
        public RawImageEditor();

        protected override void OnEnable();
        public override void OnInspectorGUI();
        public override bool HasPreviewGUI();
        public override void OnPreviewGUI(Rect rect, GUIStyle background);
        public override string GetInfoString();
    }
}
