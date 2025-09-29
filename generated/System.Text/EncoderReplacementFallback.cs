#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class EncoderReplacementFallback : EncoderFallback
    {

        public EncoderReplacementFallback();
        public EncoderReplacementFallback(string replacement);

        public string DefaultString { get; }
        public override int MaxCharCount { get; }

        public override EncoderFallbackBuffer CreateFallbackBuffer();
        public override bool Equals(object value);
        public override int GetHashCode();
    }
}
