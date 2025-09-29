#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class Math
    {

        public const double E = 2.718281828459045;
        public const double PI = 3.141592653589793;
        public const double Tau = 6.283185307179586;

        public static double Acos(double d);
        public static double Acosh(double d);
        public static double Asin(double d);
        public static double Asinh(double d);
        public static double Atan(double d);
        public static double Atanh(double d);
        public static double Atan2(double y, double x);
        public static double Cbrt(double d);
        public static double Ceiling(double a);
        public static double Cos(double d);
        public static double Cosh(double value);
        public static double Exp(double d);
        public static double Floor(double d);
        public static double FusedMultiplyAdd(double x, double y, double z);
        public static double Log(double d);
        public static double Log2(double x);
        public static double Log10(double d);
        public static double Pow(double x, double y);
        public static double Sin(double a);
        public static (double Sin, double Cos) SinCos(double x);
        public static double Sinh(double value);
        public static double Sqrt(double d);
        public static double Tan(double a);
        public static double Tanh(double value);
        public static short Abs(short value);
        public static int Abs(int value);
        public static long Abs(long value);
        public static nint Abs(nint value);
        [CLSCompliant(False)]
        public static sbyte Abs(sbyte value);
        public static decimal Abs(decimal value);
        public static double Abs(double value);
        public static float Abs(float value);
        public static long BigMul(int a, int b);
        [CLSCompliant(False)]
        public static ulong BigMul(ulong a, ulong b, out ulong low);
        public static long BigMul(long a, long b, out long low);
        public static double BitDecrement(double x);
        public static double BitIncrement(double x);
        public static double CopySign(double x, double y);
        public static int DivRem(int a, int b, out int result);
        public static long DivRem(long a, long b, out long result);
        [CLSCompliant(False)]
        public static (sbyte Quotient, sbyte Remainder) DivRem(sbyte left, sbyte right);
        public static (byte Quotient, byte Remainder) DivRem(byte left, byte right);
        public static (short Quotient, short Remainder) DivRem(short left, short right);
        [CLSCompliant(False)]
        public static (ushort Quotient, ushort Remainder) DivRem(ushort left, ushort right);
        public static (int Quotient, int Remainder) DivRem(int left, int right);
        [CLSCompliant(False)]
        public static (uint Quotient, uint Remainder) DivRem(uint left, uint right);
        public static (long Quotient, long Remainder) DivRem(long left, long right);
        [CLSCompliant(False)]
        public static (ulong Quotient, ulong Remainder) DivRem(ulong left, ulong right);
        public static (nint Quotient, nint Remainder) DivRem(nint left, nint right);
        [CLSCompliant(False)]
        public static (nuint Quotient, nuint Remainder) DivRem(nuint left, nuint right);
        public static decimal Ceiling(decimal d);
        public static byte Clamp(byte value, byte min, byte max);
        public static decimal Clamp(decimal value, decimal min, decimal max);
        public static double Clamp(double value, double min, double max);
        public static short Clamp(short value, short min, short max);
        public static int Clamp(int value, int min, int max);
        public static long Clamp(long value, long min, long max);
        public static nint Clamp(nint value, nint min, nint max);
        [CLSCompliant(False)]
        public static sbyte Clamp(sbyte value, sbyte min, sbyte max);
        public static float Clamp(float value, float min, float max);
        [CLSCompliant(False)]
        public static ushort Clamp(ushort value, ushort min, ushort max);
        [CLSCompliant(False)]
        public static uint Clamp(uint value, uint min, uint max);
        [CLSCompliant(False)]
        public static ulong Clamp(ulong value, ulong min, ulong max);
        [CLSCompliant(False)]
        public static nuint Clamp(nuint value, nuint min, nuint max);
        public static decimal Floor(decimal d);
        public static double IEEERemainder(double x, double y);
        public static int ILogB(double x);
        public static double Log(double a, double newBase);
        public static byte Max(byte val1, byte val2);
        public static decimal Max(decimal val1, decimal val2);
        public static double Max(double val1, double val2);
        public static short Max(short val1, short val2);
        public static int Max(int val1, int val2);
        public static long Max(long val1, long val2);
        public static nint Max(nint val1, nint val2);
        [CLSCompliant(False)]
        public static sbyte Max(sbyte val1, sbyte val2);
        public static float Max(float val1, float val2);
        [CLSCompliant(False)]
        public static ushort Max(ushort val1, ushort val2);
        [CLSCompliant(False)]
        public static uint Max(uint val1, uint val2);
        [CLSCompliant(False)]
        public static ulong Max(ulong val1, ulong val2);
        [CLSCompliant(False)]
        public static nuint Max(nuint val1, nuint val2);
        public static double MaxMagnitude(double x, double y);
        public static byte Min(byte val1, byte val2);
        public static decimal Min(decimal val1, decimal val2);
        public static double Min(double val1, double val2);
        public static short Min(short val1, short val2);
        public static int Min(int val1, int val2);
        public static long Min(long val1, long val2);
        public static nint Min(nint val1, nint val2);
        [CLSCompliant(False)]
        public static sbyte Min(sbyte val1, sbyte val2);
        public static float Min(float val1, float val2);
        [CLSCompliant(False)]
        public static ushort Min(ushort val1, ushort val2);
        [CLSCompliant(False)]
        public static uint Min(uint val1, uint val2);
        [CLSCompliant(False)]
        public static ulong Min(ulong val1, ulong val2);
        [CLSCompliant(False)]
        public static nuint Min(nuint val1, nuint val2);
        public static double MinMagnitude(double x, double y);
        public static double ReciprocalEstimate(double d);
        public static double ReciprocalSqrtEstimate(double d);
        public static decimal Round(decimal d);
        public static decimal Round(decimal d, int decimals);
        public static decimal Round(decimal d, MidpointRounding mode);
        public static decimal Round(decimal d, int decimals, MidpointRounding mode);
        public static double Round(double a);
        public static double Round(double value, int digits);
        public static double Round(double value, MidpointRounding mode);
        public static double Round(double value, int digits, MidpointRounding mode);
        public static int Sign(decimal value);
        public static int Sign(double value);
        public static int Sign(short value);
        public static int Sign(int value);
        public static int Sign(long value);
        public static int Sign(nint value);
        [CLSCompliant(False)]
        public static int Sign(sbyte value);
        public static int Sign(float value);
        public static decimal Truncate(decimal d);
        public static double Truncate(double d);
        public static double ScaleB(double x, int n);
    }
}
