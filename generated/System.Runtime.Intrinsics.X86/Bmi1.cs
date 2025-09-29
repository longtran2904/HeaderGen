#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Bmi1 : X86Base
    {

        public static bool IsSupported { get; }

        public static uint AndNot(uint left, uint right);
        public static uint BitFieldExtract(uint value, byte start, byte length);
        public static uint BitFieldExtract(uint value, ushort control);
        public static uint ExtractLowestSetBit(uint value);
        public static uint GetMaskUpToLowestSetBit(uint value);
        public static uint ResetLowestSetBit(uint value);
        public static uint TrailingZeroCount(uint value);
        public abstract class X64 : X86Base.X64
        {

            public static bool IsSupported { get; }

            public static ulong AndNot(ulong left, ulong right);
            public static ulong BitFieldExtract(ulong value, byte start, byte length);
            public static ulong BitFieldExtract(ulong value, ushort control);
            public static ulong ExtractLowestSetBit(ulong value);
            public static ulong GetMaskUpToLowestSetBit(ulong value);
            public static ulong ResetLowestSetBit(ulong value);
            public static ulong TrailingZeroCount(ulong value);
        }
    }
}
