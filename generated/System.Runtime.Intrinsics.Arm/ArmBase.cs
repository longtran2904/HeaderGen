#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.Arm
{
    [CLSCompliant(False)]
    public abstract class ArmBase
    {
        public static bool IsSupported { get; }

        public static int LeadingZeroCount(int value);
        public static int LeadingZeroCount(uint value);
        public static int ReverseElementBits(int value);
        public static uint ReverseElementBits(uint value);
        public static void Yield();

        public abstract class Arm64
        {
            public static bool IsSupported { get; }

            public static int LeadingSignCount(int value);
            public static int LeadingSignCount(long value);
            public static int LeadingZeroCount(long value);
            public static int LeadingZeroCount(ulong value);
            public static long MultiplyHigh(long left, long right);
            public static ulong MultiplyHigh(ulong left, ulong right);
            public static long ReverseElementBits(long value);
            public static ulong ReverseElementBits(ulong value);
        }
    }
}
