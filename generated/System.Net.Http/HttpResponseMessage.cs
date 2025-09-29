#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Net.Http.Headers;

namespace System.Net.Http
{
    public class HttpResponseMessage : IDisposable
    {

        public HttpResponseMessage();
        public HttpResponseMessage(HttpStatusCode statusCode);

        public Version Version { get; set; }
        public HttpContent Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ReasonPhrase { get; set; }
        public HttpResponseHeaders Headers { get; }
        public HttpResponseHeaders TrailingHeaders { get; }
        public HttpRequestMessage RequestMessage { get; set; }
        public bool IsSuccessStatusCode { get; }

        public HttpResponseMessage EnsureSuccessStatusCode();
        public override string ToString();
        protected virtual void Dispose(bool disposing);
        public void Dispose();
    }
}
