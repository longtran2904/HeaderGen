#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Globalization;

namespace System
{
    public readonly struct DateOnly : IComparable, IComparable<DateOnly>, IEquatable<DateOnly>, IFormattable, IParsable<DateOnly>, ISpanFormattable, ISpanParsable<DateOnly>, IUtf8SpanFormattable
    {
        public DateOnly(int year, int month, int day);
        public DateOnly(int year, int month, int day, Calendar calendar);

        public static DateOnly MinValue { get; }
        public static DateOnly MaxValue { get; }
        public int Year { get; }
        public int Month { get; }
        public int Day { get; }
        public DayOfWeek DayOfWeek { get; }
        public int DayOfYear { get; }
        public int DayNumber { get; }

        public static DateOnly FromDayNumber(int dayNumber);
        public DateOnly AddDays(int value);
        public DateOnly AddMonths(int value);
        public DateOnly AddYears(int value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out int year, out int month, out int day);
        public DateTime ToDateTime(TimeOnly time);
        public DateTime ToDateTime(TimeOnly time, DateTimeKind kind);
        public static DateOnly FromDateTime(DateTime dateTime);
        public int CompareTo(DateOnly value);
        public int CompareTo(object value);
        public bool Equals(DateOnly value);
        public override bool Equals(object value);
        public override int GetHashCode();
        public static DateOnly Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None);
        public static DateOnly ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None);
        public static DateOnly ParseExact(ReadOnlySpan<char> s, string[] formats);
        public static DateOnly ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static DateOnly Parse(string s);
        public static DateOnly Parse(string s, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static DateOnly ParseExact(string s, string format);
        public static DateOnly ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static DateOnly ParseExact(string s, string[] formats);
        public static DateOnly ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static bool TryParse(ReadOnlySpan<char> s, out DateOnly result);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles style, out DateOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, out DateOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, out DateOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateOnly result);
        public static bool TryParse(string s, out DateOnly result);
        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles style, out DateOnly result);
        public static bool TryParseExact(string s, string format, out DateOnly result);
        public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateOnly result);
        public static bool TryParseExact(string s, string[] formats, out DateOnly result);
        public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateOnly result);
        public string ToLongDateString();
        public string ToShortDateString();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static DateOnly Parse(string s, IFormatProvider provider);
        public static bool TryParse(string s, IFormatProvider provider, out DateOnly result);
        public static DateOnly Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out DateOnly result);

        public static bool operator ==(DateOnly left, DateOnly right);
        public static bool operator !=(DateOnly left, DateOnly right);
        public static bool operator >(DateOnly left, DateOnly right);
        public static bool operator >=(DateOnly left, DateOnly right);
        public static bool operator <(DateOnly left, DateOnly right);
        public static bool operator <=(DateOnly left, DateOnly right);
    }
}
