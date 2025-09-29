#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Image), True)]
    public class ImageEditor : GraphicEditor
    {
        public ImageEditor();

        protected override void OnEnable();
        protected override void OnDisable();
        public override void OnInspectorGUI();
        protected void SpriteGUI();
        protected void TypeGUI();
        public override bool HasPreviewGUI();
        public override void OnPreviewGUI(Rect rect, GUIStyle background);
        public override string GetInfoString();
    }
}
