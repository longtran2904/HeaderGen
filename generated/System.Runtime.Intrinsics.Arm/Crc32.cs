#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.Arm
{
    [CLSCompliant(False)]
    public abstract class Crc32 : ArmBase
    {

        public static bool IsSupported { get; }

        public static uint ComputeCrc32(uint crc, byte data);
        public static uint ComputeCrc32(uint crc, ushort data);
        public static uint ComputeCrc32(uint crc, uint data);
        public static uint ComputeCrc32C(uint crc, byte data);
        public static uint ComputeCrc32C(uint crc, ushort data);
        public static uint ComputeCrc32C(uint crc, uint data);
        public abstract class Arm64 : ArmBase.Arm64
        {

            public static bool IsSupported { get; }

            public static uint ComputeCrc32(uint crc, ulong data);
            public static uint ComputeCrc32C(uint crc, ulong data);
        }
    }
}
