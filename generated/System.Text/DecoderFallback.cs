#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public abstract class DecoderFallback
    {
        protected DecoderFallback();

        public static DecoderFallback ReplacementFallback { get; }
        public static DecoderFallback ExceptionFallback { get; }
        public abstract int MaxCharCount { get; }

        public abstract DecoderFallbackBuffer CreateFallbackBuffer();
    }
}
