#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Globalization;

namespace System
{
    public readonly struct TimeOnly : IComparable, IComparable<TimeOnly>, IEquatable<TimeOnly>, IFormattable, IParsable<TimeOnly>, ISpanFormattable, ISpanParsable<TimeOnly>, IUtf8SpanFormattable
    {
        public TimeOnly(int hour, int minute);
        public TimeOnly(int hour, int minute, int second);
        public TimeOnly(int hour, int minute, int second, int millisecond);
        public TimeOnly(int hour, int minute, int second, int millisecond, int microsecond);
        public TimeOnly(long ticks);

        public static TimeOnly MinValue { get; }
        public static TimeOnly MaxValue { get; }
        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }
        public int Millisecond { get; }
        public int Microsecond { get; }
        public int Nanosecond { get; }
        public long Ticks { get; }

        public TimeOnly Add(TimeSpan value);
        public TimeOnly Add(TimeSpan value, out int wrappedDays);
        public TimeOnly AddHours(double value);
        public TimeOnly AddHours(double value, out int wrappedDays);
        public TimeOnly AddMinutes(double value);
        public TimeOnly AddMinutes(double value, out int wrappedDays);
        public bool IsBetween(TimeOnly start, TimeOnly end);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out int hour, out int minute);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out int hour, out int minute, out int second);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out int hour, out int minute, out int second, out int millisecond);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out int hour, out int minute, out int second, out int millisecond, out int microsecond);
        public static TimeOnly FromTimeSpan(TimeSpan timeSpan);
        public static TimeOnly FromDateTime(DateTime dateTime);
        public TimeSpan ToTimeSpan();
        public int CompareTo(TimeOnly value);
        public int CompareTo(object value);
        public bool Equals(TimeOnly value);
        public override bool Equals(object value);
        public override int GetHashCode();
        public static TimeOnly Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None);
        public static TimeOnly ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None);
        public static TimeOnly ParseExact(ReadOnlySpan<char> s, string[] formats);
        public static TimeOnly ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static TimeOnly Parse(string s);
        public static TimeOnly Parse(string s, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static TimeOnly ParseExact(string s, string format);
        public static TimeOnly ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static TimeOnly ParseExact(string s, string[] formats);
        public static TimeOnly ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        public static bool TryParse(ReadOnlySpan<char> s, out TimeOnly result);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles style, out TimeOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, out TimeOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out TimeOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, out TimeOnly result);
        public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out TimeOnly result);
        public static bool TryParse(string s, out TimeOnly result);
        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles style, out TimeOnly result);
        public static bool TryParseExact(string s, string format, out TimeOnly result);
        public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out TimeOnly result);
        public static bool TryParseExact(string s, string[] formats, out TimeOnly result);
        public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out TimeOnly result);
        public string ToLongTimeString();
        public string ToShortTimeString();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static TimeOnly Parse(string s, IFormatProvider provider);
        public static bool TryParse(string s, IFormatProvider provider, out TimeOnly result);
        public static TimeOnly Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out TimeOnly result);

        public static bool operator ==(TimeOnly left, TimeOnly right);
        public static bool operator !=(TimeOnly left, TimeOnly right);
        public static bool operator >(TimeOnly left, TimeOnly right);
        public static bool operator >=(TimeOnly left, TimeOnly right);
        public static bool operator <(TimeOnly left, TimeOnly right);
        public static bool operator <=(TimeOnly left, TimeOnly right);
        public static TimeSpan operator -(TimeOnly t1, TimeOnly t2);
    }
}
