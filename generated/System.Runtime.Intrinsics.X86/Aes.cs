#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Aes : Sse2
    {
        public static bool IsSupported { get; }

        public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey);
        public static Vector128<byte> DecryptLast(Vector128<byte> value, Vector128<byte> roundKey);
        public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey);
        public static Vector128<byte> EncryptLast(Vector128<byte> value, Vector128<byte> roundKey);
        public static Vector128<byte> InverseMixColumns(Vector128<byte> value);
        public static Vector128<byte> KeygenAssist(Vector128<byte> value, byte control);

        public abstract class X64 : Sse2.X64
        {
            public static bool IsSupported { get; }
        }
    }
}
