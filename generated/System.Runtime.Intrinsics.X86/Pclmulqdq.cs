#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Pclmulqdq : Sse2
    {

        public static bool IsSupported { get; }

        public static Vector128<long> CarrylessMultiply(Vector128<long> left, Vector128<long> right, byte control);
        public static Vector128<ulong> CarrylessMultiply(Vector128<ulong> left, Vector128<ulong> right, byte control);
        public abstract class X64 : Sse2.X64
        {

            public static bool IsSupported { get; }
        }
    }
}
