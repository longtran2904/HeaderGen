#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Avx512CD : Avx512F
    {
        public static bool IsSupported { get; }

        public static Vector512<int> DetectConflicts(Vector512<int> value);
        public static Vector512<uint> DetectConflicts(Vector512<uint> value);
        public static Vector512<long> DetectConflicts(Vector512<long> value);
        public static Vector512<ulong> DetectConflicts(Vector512<ulong> value);
        public static Vector512<int> LeadingZeroCount(Vector512<int> value);
        public static Vector512<uint> LeadingZeroCount(Vector512<uint> value);
        public static Vector512<long> LeadingZeroCount(Vector512<long> value);
        public static Vector512<ulong> LeadingZeroCount(Vector512<ulong> value);

        public abstract class VL : Avx512F.VL
        {
            public static bool IsSupported { get; }

            public static Vector128<int> DetectConflicts(Vector128<int> value);
            public static Vector128<uint> DetectConflicts(Vector128<uint> value);
            public static Vector128<long> DetectConflicts(Vector128<long> value);
            public static Vector128<ulong> DetectConflicts(Vector128<ulong> value);
            public static Vector256<int> DetectConflicts(Vector256<int> value);
            public static Vector256<uint> DetectConflicts(Vector256<uint> value);
            public static Vector256<long> DetectConflicts(Vector256<long> value);
            public static Vector256<ulong> DetectConflicts(Vector256<ulong> value);
            public static Vector128<int> LeadingZeroCount(Vector128<int> value);
            public static Vector128<uint> LeadingZeroCount(Vector128<uint> value);
            public static Vector128<long> LeadingZeroCount(Vector128<long> value);
            public static Vector128<ulong> LeadingZeroCount(Vector128<ulong> value);
            public static Vector256<int> LeadingZeroCount(Vector256<int> value);
            public static Vector256<uint> LeadingZeroCount(Vector256<uint> value);
            public static Vector256<long> LeadingZeroCount(Vector256<long> value);
            public static Vector256<ulong> LeadingZeroCount(Vector256<ulong> value);
        }
        public abstract class X64 : Avx512F.X64
        {
            public static bool IsSupported { get; }
        }
    }
}
