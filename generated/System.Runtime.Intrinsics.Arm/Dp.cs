#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.Arm
{
    [CLSCompliant(False)]
    public abstract class Dp : AdvSimd
    {

        public static bool IsSupported { get; }

        public static Vector64<int> DotProduct(Vector64<int> addend, Vector64<sbyte> left, Vector64<sbyte> right);
        public static Vector64<uint> DotProduct(Vector64<uint> addend, Vector64<byte> left, Vector64<byte> right);
        public static Vector128<int> DotProduct(Vector128<int> addend, Vector128<sbyte> left, Vector128<sbyte> right);
        public static Vector128<uint> DotProduct(Vector128<uint> addend, Vector128<byte> left, Vector128<byte> right);
        public static Vector64<int> DotProductBySelectedQuadruplet(Vector64<int> addend, Vector64<sbyte> left, Vector64<sbyte> right, byte rightScaledIndex);
        public static Vector64<int> DotProductBySelectedQuadruplet(Vector64<int> addend, Vector64<sbyte> left, Vector128<sbyte> right, byte rightScaledIndex);
        public static Vector64<uint> DotProductBySelectedQuadruplet(Vector64<uint> addend, Vector64<byte> left, Vector64<byte> right, byte rightScaledIndex);
        public static Vector64<uint> DotProductBySelectedQuadruplet(Vector64<uint> addend, Vector64<byte> left, Vector128<byte> right, byte rightScaledIndex);
        public static Vector128<int> DotProductBySelectedQuadruplet(Vector128<int> addend, Vector128<sbyte> left, Vector128<sbyte> right, byte rightScaledIndex);
        public static Vector128<int> DotProductBySelectedQuadruplet(Vector128<int> addend, Vector128<sbyte> left, Vector64<sbyte> right, byte rightScaledIndex);
        public static Vector128<uint> DotProductBySelectedQuadruplet(Vector128<uint> addend, Vector128<byte> left, Vector128<byte> right, byte rightScaledIndex);
        public static Vector128<uint> DotProductBySelectedQuadruplet(Vector128<uint> addend, Vector128<byte> left, Vector64<byte> right, byte rightScaledIndex);
        public abstract class Arm64 : AdvSimd.Arm64
        {

            public static bool IsSupported { get; }
        }
    }
}
