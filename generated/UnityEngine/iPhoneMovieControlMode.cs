#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iPhoneMovieControlMode enumeration is deprecated. Please use FullScreenMovieControlMode instead (UnityUpgradable) -> FullScreenMovieControlMode", True)]
    public enum iPhoneMovieControlMode
    {
        Full = 0,
        Minimal = 1,
        [Obsolete]
        CancelOnTouch = 2,
        Hidden = 3,
        [Obsolete]
        VolumeOnly = 4
    }
}
