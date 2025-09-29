#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.IO;

namespace System.Text
{
    public abstract class Encoding : ICloneable
    {

        protected Encoding();
        protected Encoding(int codePage);
        protected Encoding(int codePage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);

        public static Encoding Default { get; }
        public virtual ReadOnlySpan<byte> Preamble { get; }
        public virtual string BodyName { get; }
        public virtual string EncodingName { get; }
        public virtual string HeaderName { get; }
        public virtual string WebName { get; }
        public virtual int WindowsCodePage { get; }
        public virtual bool IsBrowserDisplay { get; }
        public virtual bool IsBrowserSave { get; }
        public virtual bool IsMailNewsDisplay { get; }
        public virtual bool IsMailNewsSave { get; }
        public virtual bool IsSingleByte { get; }
        public EncoderFallback EncoderFallback { get; set; }
        public DecoderFallback DecoderFallback { get; set; }
        public bool IsReadOnly { get; }
        public static Encoding ASCII { get; }
        public static Encoding Latin1 { get; }
        public virtual int CodePage { get; }
        public static Encoding Unicode { get; }
        public static Encoding BigEndianUnicode { get; }
        [Obsolete("The UTF-7 encoding is insecure and should not be used. Consider using UTF-8 instead.", DiagnosticId = "SYSLIB0001", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static Encoding UTF7 { get; }
        public static Encoding UTF8 { get; }
        public static Encoding UTF32 { get; }

        public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes);
        public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count);
        public static void RegisterProvider(EncodingProvider provider);
        public static Encoding GetEncoding(int codepage);
        public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
        public static Encoding GetEncoding(string name);
        public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
        public static EncodingInfo[] GetEncodings();
        public virtual byte[] GetPreamble();
        public virtual object Clone();
        public virtual int GetByteCount(char[] chars);
        public virtual int GetByteCount(string s);
        public abstract int GetByteCount(char[] chars, int index, int count);
        public int GetByteCount(string s, int index, int count);
        [CLSCompliant(False)]
        public virtual int GetByteCount(char* chars, int count);
        public virtual int GetByteCount(ReadOnlySpan<char> chars);
        public virtual byte[] GetBytes(char[] chars);
        public virtual byte[] GetBytes(char[] chars, int index, int count);
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        public virtual byte[] GetBytes(string s);
        public byte[] GetBytes(string s, int index, int count);
        public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex);
        [CLSCompliant(False)]
        public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount);
        public virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes);
        public virtual bool TryGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);
        public virtual int GetCharCount(byte[] bytes);
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        [CLSCompliant(False)]
        public virtual int GetCharCount(byte* bytes, int count);
        public virtual int GetCharCount(ReadOnlySpan<byte> bytes);
        public virtual char[] GetChars(byte[] bytes);
        public virtual char[] GetChars(byte[] bytes, int index, int count);
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        [CLSCompliant(False)]
        public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount);
        public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars);
        public virtual bool TryGetChars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten);
        [CLSCompliant(False)]
        public string GetString(byte* bytes, int byteCount);
        public string GetString(ReadOnlySpan<byte> bytes);
        public bool IsAlwaysNormalized();
        public virtual bool IsAlwaysNormalized(NormalizationForm form);
        public virtual Decoder GetDecoder();
        public virtual Encoder GetEncoder();
        public abstract int GetMaxByteCount(int charCount);
        public abstract int GetMaxCharCount(int byteCount);
        public virtual string GetString(byte[] bytes);
        public virtual string GetString(byte[] bytes, int index, int count);
        public override bool Equals(object value);
        public override int GetHashCode();
        public static Stream CreateTranscodingStream(Stream innerStream, Encoding innerStreamEncoding, Encoding outerStreamEncoding, bool leaveOpen = False);
    }
}
