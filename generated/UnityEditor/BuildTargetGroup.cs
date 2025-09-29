#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/BuildPipeline/BuildTargetPlatformSpecific.h")]
    public enum BuildTargetGroup
    {

        Unknown = 0,
        Standalone = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WebPlayer was removed in 5.4, consider using WebGL", True)]
        WebPlayer = 2,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use iOS instead (UnityUpgradable) -> iOS", True)]
        iPhone = 4,
        iOS = 4,
        [Obsolete("PS3 has been removed in >=5.5")]
        PS3 = 5,
        [Obsolete("XBOX360 has been removed in 5.5")]
        XBOX360 = 6,
        Android = 7,
        WebGL = 13,
        WSA = 14,
        [Obsolete("Use WSA instead")]
        Metro = 14,
        [Obsolete("Use WSA instead")]
        WP8 = 15,
        [Obsolete("BlackBerry has been removed as of 5.4")]
        BlackBerry = 16,
        [Obsolete("Tizen has been removed in 2017.3")]
        Tizen = 17,
        [Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
        PSP2 = 18,
        PS4 = 19,
        [Obsolete("PSM has been removed in >= 5.3")]
        PSM = 20,
        XboxOne = 21,
        [Obsolete("SamsungTV has been removed as of 2017.3")]
        SamsungTV = 22,
        [Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
        N3DS = 23,
        [Obsolete("Wii U support was removed in 2018.1")]
        WiiU = 24,
        tvOS = 25,
        [Obsolete("Facebook support was removed in 2019.3")]
        Facebook = 26,
        Switch = 27,
        Lumin = 28,
        Stadia = 29,
        [Obsolete("CloudRendering is deprecated, please use LinuxHeadlessSimulation (UnityUpgradable) -> LinuxHeadlessSimulation", False)]
        CloudRendering = 30,
        LinuxHeadlessSimulation = 30,
        [Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
        GameCoreScarlett = 31,
        GameCoreXboxSeries = 31,
        GameCoreXboxOne = 32,
        PS5 = 33,
        EmbeddedLinux = 34
    }
}
