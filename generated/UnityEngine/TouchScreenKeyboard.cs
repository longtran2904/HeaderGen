#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
    [NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
    [NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
    public class TouchScreenKeyboard
    {
        public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);

        ~TouchScreenKeyboard();

        public static bool isSupported { get; }
        public static bool isInPlaceEditingAllowed { get; }
        public string text { get; set; }
        public static bool hideInput { get; set; }
        public bool active { get; set; }
        [Obsolete("Property done is deprecated, use status instead")]
        public bool done { get; }
        [Obsolete("Property wasCanceled is deprecated, use status instead.")]
        public bool wasCanceled { get; }
        public Status status { get; }
        public int characterLimit { get; set; }
        public bool canGetSelection { get; }
        public bool canSetSelection { get; }
        public RangeInt selection { get; set; }
        public TouchScreenKeyboardType type { get; }
        public int targetDisplay { get; set; }
        [NativeConditional("ENABLE_ONSCREEN_KEYBOARD", "RectT<float>()")]
        public static Rect area { get; }
        public static bool visible { get; }

        public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType);
        [ExcludeFromDocs]
        public static TouchScreenKeyboard Open(string text);

        public enum Status
        {
            Visible = 0,
            Done = 1,
            Canceled = 2,
            LostFocus = 3
        }
        public class Android
        {
            public Android();

            [Obsolete("TouchScreenKeyboard.Android.closeKeyboardOnOutsideTap is obsolete. Use TouchScreenKeyboard.Android.consumesOutsideTouches instead (UnityUpgradable) -> UnityEngine.TouchScreenKeyboard/Android.consumesOutsideTouches")]
            public static bool closeKeyboardOnOutsideTap { get; set; }
            public static bool consumesOutsideTouches { get; set; }
        }
    }
}
