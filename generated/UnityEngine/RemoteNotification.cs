#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("RemoteNotification is deprecated. Please use iOS.RemoteNotification instead (UnityUpgradable) -> UnityEngine.iOS.RemoteNotification", True)]
    public sealed class RemoteNotification
    {

        public RemoteNotification();

        public string alertBody { get; }
        public bool hasAction { get; }
        public int applicationIconBadgeNumber { get; }
        public string soundName { get; }
        public IDictionary userInfo { get; }
    }
}
