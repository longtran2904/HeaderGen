#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public abstract class DelegatingHandler : HttpMessageHandler
    {

        protected DelegatingHandler();
        protected DelegatingHandler(HttpMessageHandler innerHandler);

        public HttpMessageHandler InnerHandler { get; set; }

        protected internal override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken);
        protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        protected override void Dispose(bool disposing);
    }
}
