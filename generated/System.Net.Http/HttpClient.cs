#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class HttpClient : HttpMessageInvoker
    {

        public HttpClient();
        public HttpClient(HttpMessageHandler handler);
        public HttpClient(HttpMessageHandler handler, bool disposeHandler);

        public static IWebProxy DefaultProxy { get; set; }
        public HttpRequestHeaders DefaultRequestHeaders { get; }
        public Version DefaultRequestVersion { get; set; }
        public HttpVersionPolicy DefaultVersionPolicy { get; set; }
        public Uri BaseAddress { get; set; }
        public TimeSpan Timeout { get; set; }
        public long MaxResponseContentBufferSize { get; set; }

        public Task<string> GetStringAsync(string requestUri);
        public Task<string> GetStringAsync(Uri requestUri);
        public Task<string> GetStringAsync(string requestUri, CancellationToken cancellationToken);
        public Task<string> GetStringAsync(Uri requestUri, CancellationToken cancellationToken);
        public Task<byte[]> GetByteArrayAsync(string requestUri);
        public Task<byte[]> GetByteArrayAsync(Uri requestUri);
        public Task<byte[]> GetByteArrayAsync(string requestUri, CancellationToken cancellationToken);
        public Task<byte[]> GetByteArrayAsync(Uri requestUri, CancellationToken cancellationToken);
        public Task<Stream> GetStreamAsync(string requestUri);
        public Task<Stream> GetStreamAsync(string requestUri, CancellationToken cancellationToken);
        public Task<Stream> GetStreamAsync(Uri requestUri);
        public Task<Stream> GetStreamAsync(Uri requestUri, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> GetAsync(string requestUri);
        public Task<HttpResponseMessage> GetAsync(Uri requestUri);
        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption);
        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption);
        public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);
        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content);
        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content);
        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content);
        public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content);
        public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteAsync(string requestUri);
        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri);
        public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public HttpResponseMessage Send(HttpRequestMessage request);
        [UnsupportedOSPlatform("browser")]
        public HttpResponseMessage Send(HttpRequestMessage request, HttpCompletionOption completionOption);
        [UnsupportedOSPlatform("browser")]
        public override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public HttpResponseMessage Send(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
        public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption);
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        public void CancelPendingRequests();
        protected override void Dispose(bool disposing);
    }
}
