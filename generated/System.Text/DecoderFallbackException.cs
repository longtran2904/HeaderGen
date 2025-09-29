#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class DecoderFallbackException : ArgumentException
    {
        public DecoderFallbackException();
        public DecoderFallbackException(string message);
        public DecoderFallbackException(string message, Exception innerException);
        public DecoderFallbackException(string message, byte[] bytesUnknown, int index);

        public byte[] BytesUnknown { get; }
        public int Index { get; }
    }
}
