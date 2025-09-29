#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public class UTF8Encoding : Encoding
    {
        public UTF8Encoding();
        public UTF8Encoding(bool encoderShouldEmitUTF8Identifier);
        public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes);

        public override ReadOnlySpan<byte> Preamble { get; }

        public override int GetByteCount(char[] chars, int index, int count);
        public override int GetByteCount(string chars);
        [CLSCompliant(False)]
        public override int GetByteCount(char* chars, int count);
        public override int GetByteCount(ReadOnlySpan<char> chars);
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex);
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        [CLSCompliant(False)]
        public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount);
        public override int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes);
        public override bool TryGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);
        public override int GetCharCount(byte[] bytes, int index, int count);
        [CLSCompliant(False)]
        public override int GetCharCount(byte* bytes, int count);
        public override int GetCharCount(ReadOnlySpan<byte> bytes);
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        [CLSCompliant(False)]
        public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount);
        public override int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars);
        public override bool TryGetChars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten);
        public override string GetString(byte[] bytes, int index, int count);
        public override Decoder GetDecoder();
        public override Encoder GetEncoder();
        public override int GetMaxByteCount(int charCount);
        public override int GetMaxCharCount(int byteCount);
        public override byte[] GetPreamble();
        public override bool Equals(object value);
        public override int GetHashCode();
    }
}
