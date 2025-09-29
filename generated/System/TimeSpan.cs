#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System
{
    public readonly struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, IParsable<TimeSpan>, ISpanFormattable, ISpanParsable<TimeSpan>, IUtf8SpanFormattable
    {

        public static readonly TimeSpan Zero;
        public static readonly TimeSpan MaxValue;
        public static readonly TimeSpan MinValue;
        public const long NanosecondsPerTick = 100;
        public const long TicksPerMicrosecond = 10;
        public const long TicksPerMillisecond = 10000;
        public const long TicksPerSecond = 10000000;
        public const long TicksPerMinute = 600000000;
        public const long TicksPerHour = 36000000000;
        public const long TicksPerDay = 864000000000;

        public TimeSpan(long ticks);
        public TimeSpan(int hours, int minutes, int seconds);
        public TimeSpan(int days, int hours, int minutes, int seconds);
        public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds);
        public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds, int microseconds);

        public long Ticks { get; }
        public int Days { get; }
        public int Hours { get; }
        public int Milliseconds { get; }
        public int Microseconds { get; }
        public int Nanoseconds { get; }
        public int Minutes { get; }
        public int Seconds { get; }
        public double TotalDays { get; }
        public double TotalHours { get; }
        public double TotalMilliseconds { get; }
        public double TotalMicroseconds { get; }
        public double TotalNanoseconds { get; }
        public double TotalMinutes { get; }
        public double TotalSeconds { get; }

        public TimeSpan Add(TimeSpan ts);
        public static int Compare(TimeSpan t1, TimeSpan t2);
        public int CompareTo(object value);
        public int CompareTo(TimeSpan value);
        public static TimeSpan FromDays(double value);
        public TimeSpan Duration();
        public override bool Equals(object value);
        public bool Equals(TimeSpan obj);
        public static bool Equals(TimeSpan t1, TimeSpan t2);
        public override int GetHashCode();
        public static TimeSpan FromHours(double value);
        public static TimeSpan FromMilliseconds(double value);
        public static TimeSpan FromMicroseconds(double value);
        public static TimeSpan FromMinutes(double value);
        public TimeSpan Negate();
        public static TimeSpan FromSeconds(double value);
        public TimeSpan Subtract(TimeSpan ts);
        public TimeSpan Multiply(double factor);
        public TimeSpan Divide(double divisor);
        public double Divide(TimeSpan ts);
        public static TimeSpan FromTicks(long value);
        public static TimeSpan Parse(string s);
        public static TimeSpan Parse(string input, IFormatProvider formatProvider);
        public static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider = null);
        public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider);
        public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider);
        public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles);
        public static TimeSpan ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles = TimeSpanStyles.None);
        public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles);
        public static TimeSpan ParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles = TimeSpanStyles.None);
        public static bool TryParse(string s, out TimeSpan result);
        public static bool TryParse(ReadOnlySpan<char> s, out TimeSpan result);
        public static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result);
        public static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result);
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result);
        public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, out TimeSpan result);
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, out TimeSpan result);
        public static bool TryParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, out TimeSpan result);
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
        public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
        public static bool TryParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider formatProvider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider formatProvider = null);

        public static TimeSpan operator -(TimeSpan t);
        public static TimeSpan operator -(TimeSpan t1, TimeSpan t2);
        public static TimeSpan operator +(TimeSpan t);
        public static TimeSpan operator +(TimeSpan t1, TimeSpan t2);
        public static TimeSpan operator *(TimeSpan timeSpan, double factor);
        public static TimeSpan operator *(double factor, TimeSpan timeSpan);
        public static TimeSpan operator /(TimeSpan timeSpan, double divisor);
        public static double operator /(TimeSpan t1, TimeSpan t2);
        public static bool operator ==(TimeSpan t1, TimeSpan t2);
        public static bool operator !=(TimeSpan t1, TimeSpan t2);
        public static bool operator <(TimeSpan t1, TimeSpan t2);
        public static bool operator <=(TimeSpan t1, TimeSpan t2);
        public static bool operator >(TimeSpan t1, TimeSpan t2);
        public static bool operator >=(TimeSpan t1, TimeSpan t2);
    }
}
