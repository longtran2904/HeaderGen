#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.Arm
{
    [CLSCompliant(False)]
    public abstract class Aes : ArmBase
    {

        public static bool IsSupported { get; }

        public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey);
        public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey);
        public static Vector128<byte> InverseMixColumns(Vector128<byte> value);
        public static Vector128<byte> MixColumns(Vector128<byte> value);
        public static Vector128<long> PolynomialMultiplyWideningLower(Vector64<long> left, Vector64<long> right);
        public static Vector128<ulong> PolynomialMultiplyWideningLower(Vector64<ulong> left, Vector64<ulong> right);
        public static Vector128<long> PolynomialMultiplyWideningUpper(Vector128<long> left, Vector128<long> right);
        public static Vector128<ulong> PolynomialMultiplyWideningUpper(Vector128<ulong> left, Vector128<ulong> right);
        public abstract class Arm64 : ArmBase.Arm64
        {

            public static bool IsSupported { get; }
        }
    }
}
