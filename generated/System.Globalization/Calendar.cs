#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public abstract class Calendar : ICloneable
    {
        public const int CurrentEra = 0;

        protected Calendar();

        public virtual DateTime MinSupportedDateTime { get; }
        public virtual DateTime MaxSupportedDateTime { get; }
        public virtual CalendarAlgorithmType AlgorithmType { get; }
        public bool IsReadOnly { get; }
        public abstract int[] Eras { get; }
        protected virtual int DaysInYearBeforeMinSupportedYear { get; }
        public virtual int TwoDigitYearMax { get; set; }

        public virtual object Clone();
        public static Calendar ReadOnly(Calendar calendar);
        public virtual DateTime AddMilliseconds(DateTime time, double milliseconds);
        public virtual DateTime AddDays(DateTime time, int days);
        public virtual DateTime AddHours(DateTime time, int hours);
        public virtual DateTime AddMinutes(DateTime time, int minutes);
        public abstract DateTime AddMonths(DateTime time, int months);
        public virtual DateTime AddSeconds(DateTime time, int seconds);
        public virtual DateTime AddWeeks(DateTime time, int weeks);
        public abstract DateTime AddYears(DateTime time, int years);
        public abstract int GetDayOfMonth(DateTime time);
        public abstract DayOfWeek GetDayOfWeek(DateTime time);
        public abstract int GetDayOfYear(DateTime time);
        public virtual int GetDaysInMonth(int year, int month);
        public abstract int GetDaysInMonth(int year, int month, int era);
        public virtual int GetDaysInYear(int year);
        public abstract int GetDaysInYear(int year, int era);
        public abstract int GetEra(DateTime time);
        public virtual int GetHour(DateTime time);
        public virtual double GetMilliseconds(DateTime time);
        public virtual int GetMinute(DateTime time);
        public abstract int GetMonth(DateTime time);
        public virtual int GetMonthsInYear(int year);
        public abstract int GetMonthsInYear(int year, int era);
        public virtual int GetSecond(DateTime time);
        public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
        public abstract int GetYear(DateTime time);
        public virtual bool IsLeapDay(int year, int month, int day);
        public abstract bool IsLeapDay(int year, int month, int day, int era);
        public virtual bool IsLeapMonth(int year, int month);
        public abstract bool IsLeapMonth(int year, int month, int era);
        public virtual int GetLeapMonth(int year);
        public virtual int GetLeapMonth(int year, int era);
        public virtual bool IsLeapYear(int year);
        public abstract bool IsLeapYear(int year, int era);
        public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
        public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
        public virtual int ToFourDigitYear(int year);
    }
}
