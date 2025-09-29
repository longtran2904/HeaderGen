#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Bmi2 : X86Base
    {

        public static bool IsSupported { get; }

        public static uint ZeroHighBits(uint value, uint index);
        public static uint MultiplyNoFlags(uint left, uint right);
        public static uint MultiplyNoFlags(uint left, uint right, uint* low);
        public static uint ParallelBitDeposit(uint value, uint mask);
        public static uint ParallelBitExtract(uint value, uint mask);
        public abstract class X64 : X86Base.X64
        {

            public static bool IsSupported { get; }

            public static ulong ZeroHighBits(ulong value, ulong index);
            public static ulong MultiplyNoFlags(ulong left, ulong right);
            public static ulong MultiplyNoFlags(ulong left, ulong right, ulong* low);
            public static ulong ParallelBitDeposit(ulong value, ulong mask);
            public static ulong ParallelBitExtract(ulong value, ulong mask);
        }
    }
}
