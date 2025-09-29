#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Avx512Vbmi : Avx512BW
    {

        public static bool IsSupported { get; }

        public static Vector512<sbyte> PermuteVar64x8(Vector512<sbyte> left, Vector512<sbyte> control);
        public static Vector512<byte> PermuteVar64x8(Vector512<byte> left, Vector512<byte> control);
        public static Vector512<byte> PermuteVar64x8x2(Vector512<byte> lower, Vector512<byte> indices, Vector512<byte> upper);
        public static Vector512<sbyte> PermuteVar64x8x2(Vector512<sbyte> lower, Vector512<sbyte> indices, Vector512<sbyte> upper);
        public abstract class VL : Avx512BW.VL
        {

            public static bool IsSupported { get; }

            public static Vector128<sbyte> PermuteVar16x8(Vector128<sbyte> left, Vector128<sbyte> control);
            public static Vector128<byte> PermuteVar16x8(Vector128<byte> left, Vector128<byte> control);
            public static Vector128<byte> PermuteVar16x8x2(Vector128<byte> lower, Vector128<byte> indices, Vector128<byte> upper);
            public static Vector128<sbyte> PermuteVar16x8x2(Vector128<sbyte> lower, Vector128<sbyte> indices, Vector128<sbyte> upper);
            public static Vector256<sbyte> PermuteVar32x8(Vector256<sbyte> left, Vector256<sbyte> control);
            public static Vector256<byte> PermuteVar32x8(Vector256<byte> left, Vector256<byte> control);
            public static Vector256<byte> PermuteVar32x8x2(Vector256<byte> lower, Vector256<byte> indices, Vector256<byte> upper);
            public static Vector256<sbyte> PermuteVar32x8x2(Vector256<sbyte> lower, Vector256<sbyte> indices, Vector256<sbyte> upper);
        }
        public abstract class X64 : Avx512BW.X64
        {

            public static bool IsSupported { get; }
        }
    }
}
