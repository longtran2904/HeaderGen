#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class DecoderReplacementFallback : DecoderFallback
    {
        public DecoderReplacementFallback();
        public DecoderReplacementFallback(string replacement);

        public string DefaultString { get; }
        public override int MaxCharCount { get; }

        public override DecoderFallbackBuffer CreateFallbackBuffer();
        public override bool Equals(object value);
        public override int GetHashCode();
    }
}
