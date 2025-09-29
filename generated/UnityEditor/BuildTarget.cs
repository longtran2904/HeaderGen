#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType("Runtime/Serialize/SerializationMetaFlags.h")]
    public enum BuildTarget
    {

        StandaloneOSX = 2,
        [Obsolete("Use StandaloneOSX instead (UnityUpgradable) -> StandaloneOSX", True)]
        StandaloneOSXUniversal = 3,
        [Obsolete("StandaloneOSXIntel has been removed in 2017.3")]
        StandaloneOSXIntel = 4,
        StandaloneWindows = 5,
        [Obsolete("WebPlayer has been removed in 5.4", True)]
        WebPlayer = 6,
        [Obsolete("WebPlayerStreamed has been removed in 5.4", True)]
        WebPlayerStreamed = 7,
        iOS = 9,
        [Obsolete("PS3 has been removed in >=5.5")]
        PS3 = 10,
        [Obsolete("XBOX360 has been removed in 5.5")]
        XBOX360 = 11,
        Android = 13,
        [Obsolete("StandaloneLinux has been removed in 2019.2")]
        StandaloneLinux = 17,
        StandaloneWindows64 = 19,
        WebGL = 20,
        WSAPlayer = 21,
        StandaloneLinux64 = 24,
        [Obsolete("StandaloneLinuxUniversal has been removed in 2019.2")]
        StandaloneLinuxUniversal = 25,
        [Obsolete("Use WSAPlayer with Windows Phone 8.1 selected")]
        WP8Player = 26,
        [Obsolete("StandaloneOSXIntel64 has been removed in 2017.3")]
        StandaloneOSXIntel64 = 27,
        [Obsolete("BlackBerry has been removed in 5.4")]
        BlackBerry = 28,
        [Obsolete("Tizen has been removed in 2017.3")]
        Tizen = 29,
        [Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
        PSP2 = 30,
        PS4 = 31,
        [Obsolete("PSM has been removed in >= 5.3")]
        PSM = 32,
        XboxOne = 33,
        [Obsolete("SamsungTV has been removed in 2017.3")]
        SamsungTV = 34,
        [Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
        N3DS = 35,
        [Obsolete("Wii U support was removed in 2018.1")]
        WiiU = 36,
        tvOS = 37,
        Switch = 38,
        Lumin = 39,
        Stadia = 40,
        [Obsolete("CloudRendering is deprecated, please use LinuxHeadlessSimulation (UnityUpgradable) -> LinuxHeadlessSimulation", False)]
        CloudRendering = 41,
        LinuxHeadlessSimulation = 41,
        [Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
        GameCoreScarlett = 42,
        GameCoreXboxSeries = 42,
        GameCoreXboxOne = 43,
        PS5 = 44,
        EmbeddedLinux = 45,
        [Obsolete("Use iOS instead (UnityUpgradable) -> iOS", True)]
        iPhone = -1,
        [Obsolete("BlackBerry has been removed in 5.4")]
        BB10 = -1,
        [Obsolete("Use WSAPlayer instead (UnityUpgradable) -> WSAPlayer", True)]
        MetroPlayer = -1,
        NoTarget = -2
    }
}
