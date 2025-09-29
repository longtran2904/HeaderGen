#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System.Collections;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [AssetFileNameExtension("guiskin", new[] { })]
    [ExecuteInEditMode]
    [RequiredByNativeCode]
    public sealed class GUISkin : ScriptableObject
    {
        public GUISkin();

        public Font font { get; set; }
        public GUIStyle box { get; set; }
        public GUIStyle label { get; set; }
        public GUIStyle textField { get; set; }
        public GUIStyle textArea { get; set; }
        public GUIStyle button { get; set; }
        public GUIStyle toggle { get; set; }
        public GUIStyle window { get; set; }
        public GUIStyle horizontalSlider { get; set; }
        public GUIStyle horizontalSliderThumb { get; set; }
        public GUIStyle verticalSlider { get; set; }
        public GUIStyle verticalSliderThumb { get; set; }
        public GUIStyle horizontalScrollbar { get; set; }
        public GUIStyle horizontalScrollbarThumb { get; set; }
        public GUIStyle horizontalScrollbarLeftButton { get; set; }
        public GUIStyle horizontalScrollbarRightButton { get; set; }
        public GUIStyle verticalScrollbar { get; set; }
        public GUIStyle verticalScrollbarThumb { get; set; }
        public GUIStyle verticalScrollbarUpButton { get; set; }
        public GUIStyle verticalScrollbarDownButton { get; set; }
        public GUIStyle scrollView { get; set; }
        public GUIStyle[] customStyles { get; set; }
        public GUISettings settings { get; }

        public GUIStyle GetStyle(string styleName);
        public GUIStyle FindStyle(string styleName);
        public IEnumerator GetEnumerator();
    }
}
