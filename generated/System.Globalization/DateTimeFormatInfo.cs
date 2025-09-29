#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider
    {
        public DateTimeFormatInfo();

        public static DateTimeFormatInfo InvariantInfo { get; }
        public static DateTimeFormatInfo CurrentInfo { get; }
        public string AMDesignator { get; set; }
        public Calendar Calendar { get; set; }
        public string DateSeparator { get; set; }
        public DayOfWeek FirstDayOfWeek { get; set; }
        public CalendarWeekRule CalendarWeekRule { get; set; }
        public string FullDateTimePattern { get; set; }
        public string LongDatePattern { get; set; }
        public string LongTimePattern { get; set; }
        public string MonthDayPattern { get; set; }
        public string PMDesignator { get; set; }
        public string RFC1123Pattern { get; }
        public string ShortDatePattern { get; set; }
        public string ShortTimePattern { get; set; }
        public string SortableDateTimePattern { get; }
        public string TimeSeparator { get; set; }
        public string UniversalSortableDateTimePattern { get; }
        public string YearMonthPattern { get; set; }
        public string[] AbbreviatedDayNames { get; set; }
        public string[] ShortestDayNames { get; set; }
        public string[] DayNames { get; set; }
        public string[] AbbreviatedMonthNames { get; set; }
        public string[] MonthNames { get; set; }
        public bool IsReadOnly { get; }
        public string NativeCalendarName { get; }
        public string[] AbbreviatedMonthGenitiveNames { get; set; }
        public string[] MonthGenitiveNames { get; set; }

        public static DateTimeFormatInfo GetInstance(IFormatProvider provider);
        public object GetFormat(Type formatType);
        public object Clone();
        public int GetEra(string eraName);
        public string GetEraName(int era);
        public string GetAbbreviatedEraName(int era);
        public string GetAbbreviatedDayName(DayOfWeek dayofweek);
        public string GetShortestDayName(DayOfWeek dayOfWeek);
        public string[] GetAllDateTimePatterns();
        public string[] GetAllDateTimePatterns(char format);
        public string GetDayName(DayOfWeek dayofweek);
        public string GetAbbreviatedMonthName(int month);
        public string GetMonthName(int month);
        public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi);
        public void SetAllDateTimePatterns(string[] patterns, char format);
    }
}
