#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class SearchField
    {
        public SearchField();

        public int searchFieldControlID { get; set; }
        public bool autoSetFocusOnFindCommand { get; set; }

        public event SearchFieldCallback downOrUpArrowKeyPressed;

        public void SetFocus();
        public bool HasFocus();
        public string OnGUI(Rect rect, string text, GUIStyle style, GUIStyle cancelButtonStyle, GUIStyle emptyCancelButtonStyle);
        public string OnGUI(Rect rect, string text);
        public string OnGUI(string text, params GUILayoutOption[] options);
        public string OnToolbarGUI(Rect rect, string text);
        public string OnToolbarGUI(string text, params GUILayoutOption[] options);

        public delegate void SearchFieldCallback();
    }
}
