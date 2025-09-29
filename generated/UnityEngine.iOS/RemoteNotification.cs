#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.iOS
{
    [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
    [NativeHeader("PlatformDependent/iPhonePlayer/Notifications.h")]
    [Obsolete("iOS.Notification Services is deprecated. Consider using the Mobile Notifications package (available in the package manager) which implements the UserNotifications framework.")]
    [RequiredByNativeCode]
    public sealed class RemoteNotification
    {
        ~RemoteNotification();

        public string alertBody { get; }
        public string alertTitle { get; }
        public string soundName { get; }
        public int applicationIconBadgeNumber { get; }
        public IDictionary userInfo { get; }
        public bool hasAction { get; }
    }
}
