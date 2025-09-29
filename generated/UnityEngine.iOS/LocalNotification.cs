#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.iOS
{
    [NativeConditional("PLATFORM_IOS")]
    [NativeHeader("PlatformDependent/iPhonePlayer/Notifications.h")]
    [Obsolete("iOS.Notification Services is deprecated. Consider using the Mobile Notifications package (available in the package manager) which implements the UserNotifications framework.")]
    [RequiredByNativeCode]
    public sealed class LocalNotification
    {

        public LocalNotification();

        ~LocalNotification();

        public string timeZone { get; set; }
        public CalendarIdentifier repeatCalendar { get; set; }
        public CalendarUnit repeatInterval { get; set; }
        public DateTime fireDate { get; set; }
        public string alertBody { get; set; }
        public string alertTitle { get; set; }
        public string alertAction { get; set; }
        public string alertLaunchImage { get; set; }
        public string soundName { get; set; }
        public int applicationIconBadgeNumber { get; set; }
        public static string defaultSoundName { get; }
        [NativeThrows]
        public IDictionary userInfo { get; set; }
        public bool hasAction { get; set; }
    }
}
