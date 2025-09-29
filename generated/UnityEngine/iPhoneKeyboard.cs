#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iPhoneKeyboard class is deprecated. Please use TouchScreenKeyboard instead (UnityUpgradable) -> TouchScreenKeyboard", True)]
    public class iPhoneKeyboard
    {
        public iPhoneKeyboard();

        public string text { get; set; }
        public static bool hideInput { get; set; }
        public bool active { get; set; }
        public bool done { get; }
        public static Rect area { get; }
        public static bool visible { get; }
    }
}
