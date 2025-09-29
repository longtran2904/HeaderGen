#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("CalendarUnit is deprecated. Please use iOS.CalendarUnit instead (UnityUpgradable) -> UnityEngine.iOS.CalendarUnit", True)]
    public enum CalendarUnit
    {

        Era = 0,
        Year = 1,
        Month = 2,
        Day = 3,
        Hour = 4,
        Minute = 5,
        Second = 6,
        Week = 7,
        Weekday = 8,
        WeekdayOrdinal = 9,
        Quarter = 10
    }
}
