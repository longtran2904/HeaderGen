#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class MathF
    {

        public const float E = 2.7182817F;
        public const float PI = 3.1415927F;
        public const float Tau = 6.2831855F;

        public static float Acos(float x);
        public static float Acosh(float x);
        public static float Asin(float x);
        public static float Asinh(float x);
        public static float Atan(float x);
        public static float Atanh(float x);
        public static float Atan2(float y, float x);
        public static float Cbrt(float x);
        public static float Ceiling(float x);
        public static float Cos(float x);
        public static float Cosh(float x);
        public static float Exp(float x);
        public static float Floor(float x);
        public static float FusedMultiplyAdd(float x, float y, float z);
        public static float Log(float x);
        public static float Log2(float x);
        public static float Log10(float x);
        public static float Pow(float x, float y);
        public static float Sin(float x);
        public static (float Sin, float Cos) SinCos(float x);
        public static float Sinh(float x);
        public static float Sqrt(float x);
        public static float Tan(float x);
        public static float Tanh(float x);
        public static float Abs(float x);
        public static float BitDecrement(float x);
        public static float BitIncrement(float x);
        public static float CopySign(float x, float y);
        public static float IEEERemainder(float x, float y);
        public static int ILogB(float x);
        public static float Log(float x, float y);
        public static float Max(float x, float y);
        public static float MaxMagnitude(float x, float y);
        public static float Min(float x, float y);
        public static float MinMagnitude(float x, float y);
        public static float ReciprocalEstimate(float x);
        public static float ReciprocalSqrtEstimate(float x);
        public static float Round(float x);
        public static float Round(float x, int digits);
        public static float Round(float x, MidpointRounding mode);
        public static float Round(float x, int digits, MidpointRounding mode);
        public static int Sign(float x);
        public static float Truncate(float x);
        public static float ScaleB(float x, int n);
    }
}
