#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Ssse3 : Sse3
    {
        public static bool IsSupported { get; }

        public static Vector128<byte> Abs(Vector128<sbyte> value);
        public static Vector128<ushort> Abs(Vector128<short> value);
        public static Vector128<uint> Abs(Vector128<int> value);
        public static Vector128<sbyte> AlignRight(Vector128<sbyte> left, Vector128<sbyte> right, byte mask);
        public static Vector128<byte> AlignRight(Vector128<byte> left, Vector128<byte> right, byte mask);
        public static Vector128<short> AlignRight(Vector128<short> left, Vector128<short> right, byte mask);
        public static Vector128<ushort> AlignRight(Vector128<ushort> left, Vector128<ushort> right, byte mask);
        public static Vector128<int> AlignRight(Vector128<int> left, Vector128<int> right, byte mask);
        public static Vector128<uint> AlignRight(Vector128<uint> left, Vector128<uint> right, byte mask);
        public static Vector128<long> AlignRight(Vector128<long> left, Vector128<long> right, byte mask);
        public static Vector128<ulong> AlignRight(Vector128<ulong> left, Vector128<ulong> right, byte mask);
        public static Vector128<short> HorizontalAdd(Vector128<short> left, Vector128<short> right);
        public static Vector128<int> HorizontalAdd(Vector128<int> left, Vector128<int> right);
        public static Vector128<short> HorizontalAddSaturate(Vector128<short> left, Vector128<short> right);
        public static Vector128<short> HorizontalSubtract(Vector128<short> left, Vector128<short> right);
        public static Vector128<int> HorizontalSubtract(Vector128<int> left, Vector128<int> right);
        public static Vector128<short> HorizontalSubtractSaturate(Vector128<short> left, Vector128<short> right);
        public static Vector128<short> MultiplyAddAdjacent(Vector128<byte> left, Vector128<sbyte> right);
        public static Vector128<short> MultiplyHighRoundScale(Vector128<short> left, Vector128<short> right);
        public static Vector128<sbyte> Shuffle(Vector128<sbyte> value, Vector128<sbyte> mask);
        public static Vector128<byte> Shuffle(Vector128<byte> value, Vector128<byte> mask);
        public static Vector128<sbyte> Sign(Vector128<sbyte> left, Vector128<sbyte> right);
        public static Vector128<short> Sign(Vector128<short> left, Vector128<short> right);
        public static Vector128<int> Sign(Vector128<int> left, Vector128<int> right);

        public abstract class X64 : Sse3.X64
        {
            public static bool IsSupported { get; }
        }
    }
}
