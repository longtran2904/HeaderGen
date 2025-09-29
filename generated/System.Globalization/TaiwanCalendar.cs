#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public class TaiwanCalendar : Calendar
    {

        public TaiwanCalendar();

        public override DateTime MinSupportedDateTime { get; }
        public override DateTime MaxSupportedDateTime { get; }
        public override CalendarAlgorithmType AlgorithmType { get; }
        public override int[] Eras { get; }
        public override int TwoDigitYearMax { get; set; }

        public override DateTime AddMonths(DateTime time, int months);
        public override DateTime AddYears(DateTime time, int years);
        public override int GetDaysInMonth(int year, int month, int era);
        public override int GetDaysInYear(int year, int era);
        public override int GetDayOfMonth(DateTime time);
        public override DayOfWeek GetDayOfWeek(DateTime time);
        public override int GetDayOfYear(DateTime time);
        public override int GetMonthsInYear(int year, int era);
        public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
        public override int GetEra(DateTime time);
        public override int GetMonth(DateTime time);
        public override int GetYear(DateTime time);
        public override bool IsLeapDay(int year, int month, int day, int era);
        public override bool IsLeapYear(int year, int era);
        public override int GetLeapMonth(int year, int era);
        public override bool IsLeapMonth(int year, int month, int era);
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
        public override int ToFourDigitYear(int year);
    }
}
