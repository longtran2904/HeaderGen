#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Buffers;
using System.Globalization;

namespace System.Text
{
    public readonly struct Rune : IComparable, IComparable<Rune>, IEquatable<Rune>, IFormattable, ISpanFormattable, IUtf8SpanFormattable
    {
        public Rune(char ch);
        public Rune(char highSurrogate, char lowSurrogate);
        public Rune(int value);
        [CLSCompliant(False)]
        public Rune(uint value);

        public bool IsAscii { get; }
        public bool IsBmp { get; }
        public int Plane { get; }
        public static Rune ReplacementChar { get; }
        public int Utf16SequenceLength { get; }
        public int Utf8SequenceLength { get; }
        public int Value { get; }

        public int CompareTo(Rune other);
        public static OperationStatus DecodeFromUtf16(ReadOnlySpan<char> source, out Rune result, out int charsConsumed);
        public static OperationStatus DecodeFromUtf8(ReadOnlySpan<byte> source, out Rune result, out int bytesConsumed);
        public static OperationStatus DecodeLastFromUtf16(ReadOnlySpan<char> source, out Rune result, out int charsConsumed);
        public static OperationStatus DecodeLastFromUtf8(ReadOnlySpan<byte> source, out Rune value, out int bytesConsumed);
        public int EncodeToUtf16(Span<char> destination);
        public int EncodeToUtf8(Span<byte> destination);
        public override bool Equals(object obj);
        public bool Equals(Rune other);
        public override int GetHashCode();
        public static Rune GetRuneAt(string input, int index);
        public static bool IsValid(int value);
        [CLSCompliant(False)]
        public static bool IsValid(uint value);
        public override string ToString();
        public static bool TryCreate(char ch, out Rune result);
        public static bool TryCreate(char highSurrogate, char lowSurrogate, out Rune result);
        public static bool TryCreate(int value, out Rune result);
        [CLSCompliant(False)]
        public static bool TryCreate(uint value, out Rune result);
        public bool TryEncodeToUtf16(Span<char> destination, out int charsWritten);
        public bool TryEncodeToUtf8(Span<byte> destination, out int bytesWritten);
        public static bool TryGetRuneAt(string input, int index, out Rune value);
        public static double GetNumericValue(Rune value);
        public static UnicodeCategory GetUnicodeCategory(Rune value);
        public static bool IsControl(Rune value);
        public static bool IsDigit(Rune value);
        public static bool IsLetter(Rune value);
        public static bool IsLetterOrDigit(Rune value);
        public static bool IsLower(Rune value);
        public static bool IsNumber(Rune value);
        public static bool IsPunctuation(Rune value);
        public static bool IsSeparator(Rune value);
        public static bool IsSymbol(Rune value);
        public static bool IsUpper(Rune value);
        public static bool IsWhiteSpace(Rune value);
        public static Rune ToLower(Rune value, CultureInfo culture);
        public static Rune ToLowerInvariant(Rune value);
        public static Rune ToUpper(Rune value, CultureInfo culture);
        public static Rune ToUpperInvariant(Rune value);

        public static bool operator ==(Rune left, Rune right);
        public static bool operator !=(Rune left, Rune right);
        public static bool operator <(Rune left, Rune right);
        public static bool operator <=(Rune left, Rune right);
        public static bool operator >(Rune left, Rune right);
        public static bool operator >=(Rune left, Rune right);

        public static explicit operator Rune(char ch);
        [CLSCompliant(False)]
        public static explicit operator Rune(uint value);
        public static explicit operator Rune(int value);
    }
}
