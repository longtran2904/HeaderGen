#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.Arm
{
    [CLSCompliant(False)]
    public abstract class Rdm : AdvSimd
    {

        public static bool IsSupported { get; }

        public static Vector64<short> MultiplyRoundedDoublingAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector64<short> right);
        public static Vector64<int> MultiplyRoundedDoublingAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector64<int> right);
        public static Vector128<short> MultiplyRoundedDoublingAndAddSaturateHigh(Vector128<short> addend, Vector128<short> left, Vector128<short> right);
        public static Vector128<int> MultiplyRoundedDoublingAndAddSaturateHigh(Vector128<int> addend, Vector128<int> left, Vector128<int> right);
        public static Vector64<short> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector64<short> right);
        public static Vector64<int> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector64<int> right);
        public static Vector128<short> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector128<short> minuend, Vector128<short> left, Vector128<short> right);
        public static Vector128<int> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector128<int> minuend, Vector128<int> left, Vector128<int> right);
        public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex);
        public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector128<short> right, byte rightIndex);
        public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector64<int> right, byte rightIndex);
        public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector128<int> right, byte rightIndex);
        public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<short> addend, Vector128<short> left, Vector64<short> right, byte rightIndex);
        public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<short> addend, Vector128<short> left, Vector128<short> right, byte rightIndex);
        public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<int> addend, Vector128<int> left, Vector64<int> right, byte rightIndex);
        public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<int> addend, Vector128<int> left, Vector128<int> right, byte rightIndex);
        public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex);
        public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex);
        public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex);
        public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex);
        public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<short> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex);
        public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<short> minuend, Vector128<short> left, Vector128<short> right, byte rightIndex);
        public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<int> minuend, Vector128<int> left, Vector64<int> right, byte rightIndex);
        public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<int> minuend, Vector128<int> left, Vector128<int> right, byte rightIndex);
        public abstract class Arm64 : AdvSimd.Arm64
        {

            public static bool IsSupported { get; }

            public static Vector64<short> MultiplyRoundedDoublingAndAddSaturateHighScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right);
            public static Vector64<int> MultiplyRoundedDoublingAndAddSaturateHighScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right);
            public static Vector64<short> MultiplyRoundedDoublingAndSubtractSaturateHighScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right);
            public static Vector64<int> MultiplyRoundedDoublingAndSubtractSaturateHighScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right);
            public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex);
            public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector128<short> right, byte rightIndex);
            public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector64<int> right, byte rightIndex);
            public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector128<int> right, byte rightIndex);
            public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex);
            public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex);
            public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex);
            public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex);
        }
    }
}
