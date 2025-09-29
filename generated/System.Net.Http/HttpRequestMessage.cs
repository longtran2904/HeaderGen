#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;
using System.Net.Http.Headers;

namespace System.Net.Http
{
    public class HttpRequestMessage : IDisposable
    {

        public HttpRequestMessage();
        public HttpRequestMessage(HttpMethod method, Uri requestUri);
        public HttpRequestMessage(HttpMethod method, string requestUri);

        public Version Version { get; set; }
        public HttpVersionPolicy VersionPolicy { get; set; }
        public HttpContent Content { get; set; }
        public HttpMethod Method { get; set; }
        public Uri RequestUri { get; set; }
        public HttpRequestHeaders Headers { get; }
        [Obsolete("HttpRequestMessage.Properties has been deprecated. Use Options instead.")]
        public IDictionary<string, object> Properties { get; }
        public HttpRequestOptions Options { get; }

        public override string ToString();
        protected virtual void Dispose(bool disposing);
        public void Dispose();
    }
}
