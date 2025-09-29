#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
    public sealed class GUIStyleState
    {

        public GUIStyleState();

        ~GUIStyleState();

        [NativeProperty("Background", False, TargetType.Function)]
        public Texture2D background { get; set; }
        [NativeProperty("textColor", False, TargetType.Field)]
        public Color textColor { get; set; }
        [NativeProperty("scaledBackgrounds", False, TargetType.Field)]
        public Texture2D[] scaledBackgrounds { get; set; }
    }
}
