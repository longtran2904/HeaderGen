#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class HttpMessageInvoker : IDisposable
    {
        public HttpMessageInvoker(HttpMessageHandler handler);
        public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler);

        [UnsupportedOSPlatform("browser")]
        public virtual HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken);
        public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
