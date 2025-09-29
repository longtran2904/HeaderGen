#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public abstract class Decoder
    {

        protected Decoder();

        public DecoderFallback Fallback { get; set; }
        public DecoderFallbackBuffer FallbackBuffer { get; }

        public virtual void Reset();
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush);
        [CLSCompliant(False)]
        public virtual int GetCharCount(byte* bytes, int count, bool flush);
        public virtual int GetCharCount(ReadOnlySpan<byte> bytes, bool flush);
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush);
        [CLSCompliant(False)]
        public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush);
        public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush);
        public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed);
        [CLSCompliant(False)]
        public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed);
        public virtual void Convert(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush, out int bytesUsed, out int charsUsed, out bool completed);
    }
}
