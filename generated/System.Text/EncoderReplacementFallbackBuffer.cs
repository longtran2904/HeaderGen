#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
    {
        public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback);

        public override int Remaining { get; }

        public override bool Fallback(char charUnknown, int index);
        public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
        public override char GetNextChar();
        public override bool MovePrevious();
        public override void Reset();
    }
}
