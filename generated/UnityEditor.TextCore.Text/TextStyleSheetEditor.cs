#region UnityEditor.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.TextCoreTextEngineModule.dll
#endregion

using UnityEngine.TextCore.Text;

namespace UnityEditor.TextCore.Text
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TextStyleSheet))]
    public class TextStyleSheetEditor : Editor
    {
        public TextStyleSheetEditor();

        public override void OnInspectorGUI();
    }
}
