#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("RemoteNotificationType is deprecated. Please use iOS.NotificationType instead (UnityUpgradable) -> UnityEngine.iOS.NotificationType", True)]
    public enum RemoteNotificationType
    {

        None = 0,
        Badge = 1,
        Sound = 2,
        Alert = 3
    }
}
