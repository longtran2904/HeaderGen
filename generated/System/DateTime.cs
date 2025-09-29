#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
    public readonly struct DateTime : IComparable, IComparable<DateTime>, IConvertible, IEquatable<DateTime>, IFormattable, IParsable<DateTime>, ISerializable, ISpanFormattable, ISpanParsable<DateTime>, IUtf8SpanFormattable
    {

        public static readonly DateTime MinValue;
        public static readonly DateTime MaxValue;
        public static readonly DateTime UnixEpoch;

        public DateTime(long ticks);
        public DateTime(long ticks, DateTimeKind kind);
        public DateTime(DateOnly date, TimeOnly time);
        public DateTime(DateOnly date, TimeOnly time, DateTimeKind kind);
        public DateTime(int year, int month, int day);
        public DateTime(int year, int month, int day, Calendar calendar);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind);
        public DateTime(int year, int month, int day, int hour, int minute, int second);
        public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind);
        public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, DateTimeKind kind);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, Calendar calendar);
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, Calendar calendar, DateTimeKind kind);

        public DateTime Date { get; }
        public int Day { get; }
        public DayOfWeek DayOfWeek { get; }
        public int DayOfYear { get; }
        public int Hour { get; }
        public DateTimeKind Kind { get; }
        public int Millisecond { get; }
        public int Microsecond { get; }
        public int Nanosecond { get; }
        public int Minute { get; }
        public int Month { get; }
        public static DateTime Now { get; }
        public int Second { get; }
        public long Ticks { get; }
        public TimeSpan TimeOfDay { get; }
        public static DateTime Today { get; }
        public int Year { get; }
        public static DateTime UtcNow { get; }

        public DateTime Add(TimeSpan value);
        public DateTime AddDays(double value);
        public DateTime AddHours(double value);
        public DateTime AddMilliseconds(double value);
        public DateTime AddMicroseconds(double value);
        public DateTime AddMinutes(double value);
        public DateTime AddMonths(int months);
        public DateTime AddSeconds(double value);
        public DateTime AddTicks(long value);
        public DateTime AddYears(int value);
        public static int Compare(DateTime t1, DateTime t2);
        public int CompareTo(object value);
        public int CompareTo(DateTime value);
        public static int DaysInMonth(int year, int month);
        public override bool Equals(object value);
        public bool Equals(DateTime value);
        public static bool Equals(DateTime t1, DateTime t2);
        public static DateTime FromBinary(long dateData);
        public static DateTime FromFileTime(long fileTime);
        public static DateTime FromFileTimeUtc(long fileTime);
        public static DateTime FromOADate(double d);
        public bool IsDaylightSavingTime();
        public static DateTime SpecifyKind(DateTime value, DateTimeKind kind);
        public long ToBinary();
        public override int GetHashCode();
        public static bool IsLeapYear(int year);
        public static DateTime Parse(string s);
        public static DateTime Parse(string s, IFormatProvider provider);
        public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
        public static DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None);
        public static DateTime ParseExact(string s, string format, IFormatProvider provider);
        public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);
        public static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);
        public static DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public TimeSpan Subtract(DateTime value);
        public DateTime Subtract(TimeSpan value);
        public double ToOADate();
        public long ToFileTime();
        public long ToFileTimeUtc();
        public DateTime ToLocalTime();
        public string ToLongDateString();
        public string ToLongTimeString();
        public string ToShortDateString();
        public string ToShortTimeString();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public DateTime ToUniversalTime();
        public static bool TryParse(string s, out DateTime result);
        public static bool TryParse(ReadOnlySpan<char> s, out DateTime result);
        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out DateOnly date, out TimeOnly time);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out int year, out int month, out int day);
        public string[] GetDateTimeFormats();
        public string[] GetDateTimeFormats(IFormatProvider provider);
        public string[] GetDateTimeFormats(char format);
        public string[] GetDateTimeFormats(char format, IFormatProvider provider);
        public TypeCode GetTypeCode();
        public static bool TryParse(string s, IFormatProvider provider, out DateTime result);
        public static DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out DateTime result);

        public static DateTime operator +(DateTime d, TimeSpan t);
        public static DateTime operator -(DateTime d, TimeSpan t);
        public static TimeSpan operator -(DateTime d1, DateTime d2);
        public static bool operator ==(DateTime d1, DateTime d2);
        public static bool operator !=(DateTime d1, DateTime d2);
        public static bool operator <(DateTime t1, DateTime t2);
        public static bool operator <=(DateTime t1, DateTime t2);
        public static bool operator >(DateTime t1, DateTime t2);
        public static bool operator >=(DateTime t1, DateTime t2);
    }
}
