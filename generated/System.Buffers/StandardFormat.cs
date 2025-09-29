#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Buffers
{
    public readonly struct StandardFormat : IEquatable<StandardFormat>
    {

        public const byte NoPrecision = 255;
        public const byte MaxPrecision = 99;

        public StandardFormat(char symbol, byte precision = 255);

        public char Symbol { get; }
        public byte Precision { get; }
        public bool HasPrecision { get; }
        public bool IsDefault { get; }

        public static StandardFormat Parse(ReadOnlySpan<char> format);
        public static StandardFormat Parse(string format);
        public static bool TryParse(ReadOnlySpan<char> format, out StandardFormat result);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public bool Equals(StandardFormat other);
        public override string ToString();

        public static bool operator ==(StandardFormat left, StandardFormat right);
        public static bool operator !=(StandardFormat left, StandardFormat right);

        public static implicit operator StandardFormat(char symbol);
    }
}
