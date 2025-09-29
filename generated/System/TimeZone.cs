#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System
{
    [Obsolete("System.TimeZone has been deprecated. Investigate the use of System.TimeZoneInfo instead.")]
    public abstract class TimeZone
    {
        protected TimeZone();

        public static TimeZone CurrentTimeZone { get; }
        public abstract string StandardName { get; }
        public abstract string DaylightName { get; }

        public abstract TimeSpan GetUtcOffset(DateTime time);
        public virtual DateTime ToUniversalTime(DateTime time);
        public virtual DateTime ToLocalTime(DateTime time);
        public abstract DaylightTime GetDaylightChanges(int year);
        public virtual bool IsDaylightSavingTime(DateTime time);
        public static bool IsDaylightSavingTime(DateTime time, DaylightTime daylightTimes);
    }
}
