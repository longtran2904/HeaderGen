#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public class MediaTypeHeaderValue : ICloneable
    {

        protected MediaTypeHeaderValue(MediaTypeHeaderValue source);
        public MediaTypeHeaderValue(string mediaType);
        public MediaTypeHeaderValue(string mediaType, string charSet);

        public string CharSet { get; set; }
        public ICollection<NameValueHeaderValue> Parameters { get; }
        public string MediaType { get; set; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static MediaTypeHeaderValue Parse(string input);
        public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue);
    }
}
