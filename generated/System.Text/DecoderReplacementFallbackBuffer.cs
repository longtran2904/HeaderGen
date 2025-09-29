#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback);

        public override int Remaining { get; }

        public override bool Fallback(byte[] bytesUnknown, int index);
        public override char GetNextChar();
        public override bool MovePrevious();
        public override void Reset();
    }
}
