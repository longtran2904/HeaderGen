#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
    public readonly struct DateTimeOffset : IComparable, IComparable<DateTimeOffset>, IDeserializationCallback, IEquatable<DateTimeOffset>, IFormattable, IParsable<DateTimeOffset>, ISerializable, ISpanFormattable, ISpanParsable<DateTimeOffset>, IUtf8SpanFormattable
    {
        public static readonly DateTimeOffset MinValue;
        public static readonly DateTimeOffset MaxValue;
        public static readonly DateTimeOffset UnixEpoch;

        public DateTimeOffset(long ticks, TimeSpan offset);
        public DateTimeOffset(DateTime dateTime);
        public DateTimeOffset(DateTime dateTime, TimeSpan offset);
        public DateTimeOffset(DateOnly date, TimeOnly time, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, Calendar calendar, TimeSpan offset);

        public static DateTimeOffset UtcNow { get; }
        public DateTime DateTime { get; }
        public DateTime UtcDateTime { get; }
        public DateTime LocalDateTime { get; }
        public DateTime Date { get; }
        public int Day { get; }
        public DayOfWeek DayOfWeek { get; }
        public int DayOfYear { get; }
        public int Hour { get; }
        public int Millisecond { get; }
        public int Microsecond { get; }
        public int Nanosecond { get; }
        public int Minute { get; }
        public int Month { get; }
        public TimeSpan Offset { get; }
        public int TotalOffsetMinutes { get; }
        public int Second { get; }
        public long Ticks { get; }
        public long UtcTicks { get; }
        public TimeSpan TimeOfDay { get; }
        public int Year { get; }
        public static DateTimeOffset Now { get; }

        public DateTimeOffset ToOffset(TimeSpan offset);
        public DateTimeOffset Add(TimeSpan timeSpan);
        public DateTimeOffset AddDays(double days);
        public DateTimeOffset AddHours(double hours);
        public DateTimeOffset AddMilliseconds(double milliseconds);
        public DateTimeOffset AddMicroseconds(double microseconds);
        public DateTimeOffset AddMinutes(double minutes);
        public DateTimeOffset AddMonths(int months);
        public DateTimeOffset AddSeconds(double seconds);
        public DateTimeOffset AddTicks(long ticks);
        public DateTimeOffset AddYears(int years);
        public static int Compare(DateTimeOffset first, DateTimeOffset second);
        public int CompareTo(DateTimeOffset other);
        public override bool Equals(object obj);
        public bool Equals(DateTimeOffset other);
        public bool EqualsExact(DateTimeOffset other);
        public static bool Equals(DateTimeOffset first, DateTimeOffset second);
        public static DateTimeOffset FromFileTime(long fileTime);
        public static DateTimeOffset FromUnixTimeSeconds(long seconds);
        public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds);
        public override int GetHashCode();
        public static DateTimeOffset Parse(string input);
        public static DateTimeOffset Parse(string input, IFormatProvider formatProvider);
        public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles);
        public static DateTimeOffset Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None);
        public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider);
        public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles);
        public static DateTimeOffset ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, DateTimeStyles styles = DateTimeStyles.None);
        public static DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles);
        public static DateTimeOffset ParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles = DateTimeStyles.None);
        public TimeSpan Subtract(DateTimeOffset value);
        public DateTimeOffset Subtract(TimeSpan value);
        public long ToFileTime();
        public long ToUnixTimeSeconds();
        public long ToUnixTimeMilliseconds();
        public DateTimeOffset ToLocalTime();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider formatProvider);
        public string ToString(string format, IFormatProvider formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider formatProvider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider formatProvider = null);
        public DateTimeOffset ToUniversalTime();
        public static bool TryParse(string input, out DateTimeOffset result);
        public static bool TryParse(ReadOnlySpan<char> input, out DateTimeOffset result);
        public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
        public static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
        public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
        public static bool TryParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out DateOnly date, out TimeOnly time, out TimeSpan offset);
        public static bool TryParse(string s, IFormatProvider provider, out DateTimeOffset result);
        public static DateTimeOffset Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out DateTimeOffset result);

        public static DateTimeOffset operator +(DateTimeOffset dateTimeOffset, TimeSpan timeSpan);
        public static DateTimeOffset operator -(DateTimeOffset dateTimeOffset, TimeSpan timeSpan);
        public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right);
        public static bool operator ==(DateTimeOffset left, DateTimeOffset right);
        public static bool operator !=(DateTimeOffset left, DateTimeOffset right);
        public static bool operator <(DateTimeOffset left, DateTimeOffset right);
        public static bool operator <=(DateTimeOffset left, DateTimeOffset right);
        public static bool operator >(DateTimeOffset left, DateTimeOffset right);
        public static bool operator >=(DateTimeOffset left, DateTimeOffset right);

        public static implicit operator DateTimeOffset(DateTime dateTime);
    }
}
