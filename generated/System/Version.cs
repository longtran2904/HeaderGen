#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, IFormattable, ISpanFormattable, IUtf8SpanFormattable
    {
        public Version(int major, int minor, int build, int revision);
        public Version(int major, int minor, int build);
        public Version(int major, int minor);
        public Version(string version);
        public Version();

        public int Major { get; }
        public int Minor { get; }
        public int Build { get; }
        public int Revision { get; }
        public short MajorRevision { get; }
        public short MinorRevision { get; }

        public object Clone();
        public int CompareTo(object version);
        public int CompareTo(Version value);
        public override bool Equals(object obj);
        public bool Equals(Version obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(int fieldCount);
        public bool TryFormat(Span<char> destination, out int charsWritten);
        public bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten);
        public bool TryFormat(Span<byte> utf8Destination, int fieldCount, out int bytesWritten);
        public static Version Parse(string input);
        public static Version Parse(ReadOnlySpan<char> input);
        public static bool TryParse(string input, out Version result);
        public static bool TryParse(ReadOnlySpan<char> input, out Version result);

        public static bool operator ==(Version v1, Version v2);
        public static bool operator !=(Version v1, Version v2);
        public static bool operator <(Version v1, Version v2);
        public static bool operator <=(Version v1, Version v2);
        public static bool operator >(Version v1, Version v2);
        public static bool operator >=(Version v1, Version v2);
    }
}
