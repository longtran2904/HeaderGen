#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
    public sealed class GUISettings
    {

        public GUISettings();

        public bool doubleClickSelectsWord { get; set; }
        public bool tripleClickSelectsLine { get; set; }
        public Color cursorColor { get; set; }
        public float cursorFlashSpeed { get; set; }
        public Color selectionColor { get; set; }
    }
}
