#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("LocalNotification is deprecated. Please use iOS.LocalNotification instead (UnityUpgradable) -> UnityEngine.iOS.LocalNotification", True)]
    public sealed class LocalNotification
    {
        public LocalNotification();

        public DateTime fireDate { get; set; }
        public string timeZone { get; set; }
        public CalendarUnit repeatInterval { get; set; }
        public CalendarIdentifier repeatCalendar { get; set; }
        public string alertBody { get; set; }
        public string alertAction { get; set; }
        public bool hasAction { get; set; }
        public string alertLaunchImage { get; set; }
        public int applicationIconBadgeNumber { get; set; }
        public string soundName { get; set; }
        public static string defaultSoundName { get; }
        public IDictionary userInfo { get; set; }
    }
}
