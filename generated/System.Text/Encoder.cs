#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public abstract class Encoder
    {
        protected Encoder();

        public EncoderFallback Fallback { get; set; }
        public EncoderFallbackBuffer FallbackBuffer { get; }

        public virtual void Reset();
        public abstract int GetByteCount(char[] chars, int index, int count, bool flush);
        [CLSCompliant(False)]
        public virtual int GetByteCount(char* chars, int count, bool flush);
        public virtual int GetByteCount(ReadOnlySpan<char> chars, bool flush);
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);
        [CLSCompliant(False)]
        public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush);
        public virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, bool flush);
        public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed);
        [CLSCompliant(False)]
        public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed);
        public virtual void Convert(ReadOnlySpan<char> chars, Span<byte> bytes, bool flush, out int charsUsed, out int bytesUsed, out bool completed);
    }
}
