#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine.Apple.TV
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("UnityEngine.Apple.TV.Remote has been deprecated. Use UnityEngine.tvOS.Remote instead (UnityUpgradable) -> UnityEngine.tvOS.Remote", True)]
    public sealed class Remote
    {
        public Remote();

        public static bool allowExitToHome { get; set; }
        public static bool allowRemoteRotation { get; set; }
        public static bool reportAbsoluteDpadValues { get; set; }
        public static bool touchesEnabled { get; set; }
    }
}
