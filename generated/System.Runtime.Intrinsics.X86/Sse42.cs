#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Sse42 : Sse41
    {

        public static bool IsSupported { get; }

        public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right);
        public static uint Crc32(uint crc, byte data);
        public static uint Crc32(uint crc, ushort data);
        public static uint Crc32(uint crc, uint data);
        public abstract class X64 : Sse41.X64
        {

            public static bool IsSupported { get; }

            public static ulong Crc32(ulong crc, ulong data);
        }
    }
}
