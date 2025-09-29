#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public abstract class EncoderFallbackBuffer
    {
        protected EncoderFallbackBuffer();

        public abstract int Remaining { get; }

        public abstract bool Fallback(char charUnknown, int index);
        public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
        public abstract char GetNextChar();
        public abstract bool MovePrevious();
        public virtual void Reset();
    }
}
