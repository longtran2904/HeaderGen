#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public sealed class HttpContentHeaders : HttpHeaders
    {
        public ICollection<string> Allow { get; }
        public ContentDispositionHeaderValue ContentDisposition { get; set; }
        public ICollection<string> ContentEncoding { get; }
        public ICollection<string> ContentLanguage { get; }
        public long? ContentLength { get; set; }
        public Uri ContentLocation { get; set; }
        public byte[] ContentMD5 { get; set; }
        public ContentRangeHeaderValue ContentRange { get; set; }
        public MediaTypeHeaderValue ContentType { get; set; }
        public DateTimeOffset? Expires { get; set; }
        public DateTimeOffset? LastModified { get; set; }
    }
}
