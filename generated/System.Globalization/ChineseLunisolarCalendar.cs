#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public class ChineseLunisolarCalendar : EastAsianLunisolarCalendar
    {
        public const int ChineseEra = 1;

        public ChineseLunisolarCalendar();

        public override DateTime MinSupportedDateTime { get; }
        public override DateTime MaxSupportedDateTime { get; }
        protected override int DaysInYearBeforeMinSupportedYear { get; }
        public override int[] Eras { get; }

        public override int GetEra(DateTime time);
    }
}
