#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public abstract class EncoderFallback
    {
        protected EncoderFallback();

        public static EncoderFallback ReplacementFallback { get; }
        public static EncoderFallback ExceptionFallback { get; }
        public abstract int MaxCharCount { get; }

        public abstract EncoderFallbackBuffer CreateFallbackBuffer();
    }
}
