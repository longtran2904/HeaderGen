#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Sse : X86Base
    {
        public static bool IsSupported { get; }

        public static Vector128<float> Add(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> AddScalar(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> And(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> AndNot(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareGreaterThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareLessThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareLessThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareNotEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareNotGreaterThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareNotGreaterThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareNotLessThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareNotLessThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareOrdered(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarGreaterThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarGreaterThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarLessThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarLessThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarNotEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarNotGreaterThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarNotGreaterThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarNotLessThan(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarNotLessThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarOrdered(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarOrderedEqual(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarOrderedGreaterThan(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarOrderedGreaterThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarOrderedLessThan(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarOrderedLessThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarOrderedNotEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareScalarUnordered(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarUnorderedEqual(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarUnorderedGreaterThan(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarUnorderedGreaterThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarUnorderedLessThan(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarUnorderedLessThanOrEqual(Vector128<float> left, Vector128<float> right);
        public static bool CompareScalarUnorderedNotEqual(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> CompareUnordered(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, int value);
        public static int ConvertToInt32(Vector128<float> value);
        public static int ConvertToInt32WithTruncation(Vector128<float> value);
        public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> DivideScalar(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> LoadAlignedVector128(float* address);
        public static Vector128<float> LoadHigh(Vector128<float> lower, float* address);
        public static Vector128<float> LoadLow(Vector128<float> upper, float* address);
        public static Vector128<float> LoadScalarVector128(float* address);
        public static Vector128<float> LoadVector128(float* address);
        public static Vector128<float> Max(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> MaxScalar(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> Min(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> MinScalar(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> MoveHighToLow(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> MoveLowToHigh(Vector128<float> left, Vector128<float> right);
        public static int MoveMask(Vector128<float> value);
        public static Vector128<float> MoveScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> MultiplyScalar(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> Or(Vector128<float> left, Vector128<float> right);
        public static void Prefetch0(void* address);
        public static void Prefetch1(void* address);
        public static void Prefetch2(void* address);
        public static void PrefetchNonTemporal(void* address);
        public static Vector128<float> Reciprocal(Vector128<float> value);
        public static Vector128<float> ReciprocalScalar(Vector128<float> value);
        public static Vector128<float> ReciprocalScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<float> ReciprocalSqrt(Vector128<float> value);
        public static Vector128<float> ReciprocalSqrtScalar(Vector128<float> value);
        public static Vector128<float> ReciprocalSqrtScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<float> Shuffle(Vector128<float> left, Vector128<float> right, byte control);
        public static Vector128<float> Sqrt(Vector128<float> value);
        public static Vector128<float> SqrtScalar(Vector128<float> value);
        public static Vector128<float> SqrtScalar(Vector128<float> upper, Vector128<float> value);
        public static void Store(float* address, Vector128<float> source);
        public static void StoreAligned(float* address, Vector128<float> source);
        public static void StoreAlignedNonTemporal(float* address, Vector128<float> source);
        public static void StoreFence();
        public static void StoreHigh(float* address, Vector128<float> source);
        public static void StoreLow(float* address, Vector128<float> source);
        public static void StoreScalar(float* address, Vector128<float> source);
        public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> SubtractScalar(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> UnpackHigh(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> UnpackLow(Vector128<float> left, Vector128<float> right);
        public static Vector128<float> Xor(Vector128<float> left, Vector128<float> right);

        public abstract class X64 : X86Base.X64
        {
            public static bool IsSupported { get; }

            public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, long value);
            public static long ConvertToInt64(Vector128<float> value);
            public static long ConvertToInt64WithTruncation(Vector128<float> value);
        }
    }
}
