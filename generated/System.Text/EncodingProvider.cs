#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Text
{
    public abstract class EncodingProvider
    {

        public EncodingProvider();

        public abstract Encoding GetEncoding(string name);
        public abstract Encoding GetEncoding(int codepage);
        public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
        public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
        public virtual IEnumerable<EncodingInfo> GetEncodings();
    }
}
