#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public static class ISOWeek
    {

        public static int GetWeekOfYear(DateTime date);
        public static int GetYear(DateTime date);
        public static DateTime GetYearStart(int year);
        public static DateTime GetYearEnd(int year);
        public static int GetWeeksInYear(int year);
        public static DateTime ToDateTime(int year, int week, DayOfWeek dayOfWeek);
    }
}
