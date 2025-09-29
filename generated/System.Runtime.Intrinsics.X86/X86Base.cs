#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class X86Base
    {

        public static bool IsSupported { get; }

        public static (int Eax, int Ebx, int Ecx, int Edx) CpuId(int functionId, int subFunctionId);
        [RequiresPreviewFeatures("DivRem is in preview.")]
        public static (uint Quotient, uint Remainder) DivRem(uint lower, uint upper, uint divisor);
        [RequiresPreviewFeatures("DivRem is in preview.")]
        public static (int Quotient, int Remainder) DivRem(uint lower, int upper, int divisor);
        [RequiresPreviewFeatures("DivRem is in preview.")]
        public static (nuint Quotient, nuint Remainder) DivRem(nuint lower, nuint upper, nuint divisor);
        [RequiresPreviewFeatures("DivRem is in preview.")]
        public static (nint Quotient, nint Remainder) DivRem(nuint lower, nint upper, nint divisor);
        public static void Pause();
        public abstract class X64
        {

            public static bool IsSupported { get; }

            [RequiresPreviewFeatures("DivRem is in preview.")]
            public static (ulong Quotient, ulong Remainder) DivRem(ulong lower, ulong upper, ulong divisor);
            [RequiresPreviewFeatures("DivRem is in preview.")]
            public static (long Quotient, long Remainder) DivRem(ulong lower, long upper, long divisor);
        }
    }
}
