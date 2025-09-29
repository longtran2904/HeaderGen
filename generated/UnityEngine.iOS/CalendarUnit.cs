#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.iOS
{
    [Obsolete("iOS.Notification Services is deprecated. Consider using the Mobile Notifications package (available in the package manager) which implements the UserNotifications framework.")]
    public enum CalendarUnit
    {
        Era = 2,
        Year = 4,
        Month = 8,
        Day = 16,
        Hour = 32,
        Minute = 64,
        Second = 128,
        Week = 256,
        Weekday = 512,
        WeekdayOrdinal = 1024,
        Quarter = 2048
    }
}
