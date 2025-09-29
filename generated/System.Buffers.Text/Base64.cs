#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Buffers.Text
{
    public static class Base64
    {
        public static OperationStatus EncodeToUtf8(ReadOnlySpan<byte> bytes, Span<byte> utf8, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = True);
        public static int GetMaxEncodedToUtf8Length(int length);
        public static OperationStatus EncodeToUtf8InPlace(Span<byte> buffer, int dataLength, out int bytesWritten);
        public static OperationStatus DecodeFromUtf8(ReadOnlySpan<byte> utf8, Span<byte> bytes, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = True);
        public static int GetMaxDecodedFromUtf8Length(int length);
        public static OperationStatus DecodeFromUtf8InPlace(Span<byte> buffer, out int bytesWritten);
        public static bool IsValid(ReadOnlySpan<char> base64Text);
        public static bool IsValid(ReadOnlySpan<char> base64Text, out int decodedLength);
        public static bool IsValid(ReadOnlySpan<byte> base64TextUtf8);
        public static bool IsValid(ReadOnlySpan<byte> base64TextUtf8, out int decodedLength);
    }
}
