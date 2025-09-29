#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public readonly struct Boolean : IComparable, IComparable<bool>, IConvertible, IEquatable<bool>, IParsable<bool>, ISpanParsable<bool>
    {
        public static readonly string TrueString;
        public static readonly string FalseString;

        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten);
        public override bool Equals(object obj);
        public bool Equals(bool obj);
        public int CompareTo(object obj);
        public int CompareTo(bool value);
        public static bool Parse(string value);
        public static bool Parse(ReadOnlySpan<char> value);
        public static bool TryParse(string value, out bool result);
        public static bool TryParse(ReadOnlySpan<char> value, out bool result);
        public TypeCode GetTypeCode();
    }
}
