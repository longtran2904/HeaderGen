#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum GameViewSizeGroupType
    {
        Standalone = 0,
        [Obsolete("WebPlayer has been removed in 5.4")]
        WebPlayer = 1,
        iOS = 2,
        Android = 3,
        [Obsolete("PS3 has been removed in 5.5", False)]
        PS3 = 4,
        [Obsolete("Wii U support was removed in 2018.1", False)]
        WiiU = 5,
        [Obsolete("Tizen has been removed in 2017.3", False)]
        Tizen = 6,
        [Obsolete("Windows Phone 8 was removed in 5.3", False)]
        WP8 = 7,
        [Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
        N3DS = 8,
        HMD = 9
    }
}
