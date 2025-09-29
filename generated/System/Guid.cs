#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public readonly struct Guid : IComparable, IComparable<Guid>, IEquatable<Guid>, IFormattable, IParsable<Guid>, ISpanFormattable, ISpanParsable<Guid>, IUtf8SpanFormattable
    {

        public static readonly Guid Empty;

        public Guid(byte[] b);
        public Guid(ReadOnlySpan<byte> b);
        public Guid(ReadOnlySpan<byte> b, bool bigEndian);
        [CLSCompliant(False)]
        public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
        public Guid(int a, short b, short c, byte[] d);
        public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
        public Guid(string g);

        public static Guid Parse(string input);
        public static Guid Parse(ReadOnlySpan<char> input);
        public static bool TryParse(string input, out Guid result);
        public static bool TryParse(ReadOnlySpan<char> input, out Guid result);
        public static Guid ParseExact(string input, string format);
        public static Guid ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format);
        public static bool TryParseExact(string input, string format, out Guid result);
        public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result);
        public byte[] ToByteArray();
        public byte[] ToByteArray(bool bigEndian);
        public bool TryWriteBytes(Span<byte> destination);
        public bool TryWriteBytes(Span<byte> destination, bool bigEndian, out int bytesWritten);
        public override int GetHashCode();
        public override bool Equals(object o);
        public bool Equals(Guid g);
        public int CompareTo(object value);
        public int CompareTo(Guid value);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null);
        public static Guid Parse(string s, IFormatProvider provider);
        public static bool TryParse(string s, IFormatProvider provider, out Guid result);
        public static Guid Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out Guid result);
        public static Guid NewGuid();

        public static bool operator ==(Guid a, Guid b);
        public static bool operator !=(Guid a, Guid b);
        public static bool operator <(Guid left, Guid right);
        public static bool operator <=(Guid left, Guid right);
        public static bool operator >(Guid left, Guid right);
        public static bool operator >=(Guid left, Guid right);
    }
}
