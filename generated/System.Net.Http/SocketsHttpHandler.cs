#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.Security;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    [UnsupportedOSPlatform("browser")]
    public sealed class SocketsHttpHandler : HttpMessageHandler
    {

        public SocketsHttpHandler();

        [UnsupportedOSPlatformGuard("browser")]
        public static bool IsSupported { get; }
        public bool UseCookies { get; set; }
        public CookieContainer CookieContainer { get; set; }
        public DecompressionMethods AutomaticDecompression { get; set; }
        public bool UseProxy { get; set; }
        public IWebProxy Proxy { get; set; }
        public ICredentials DefaultProxyCredentials { get; set; }
        public bool PreAuthenticate { get; set; }
        public ICredentials Credentials { get; set; }
        public bool AllowAutoRedirect { get; set; }
        public int MaxAutomaticRedirections { get; set; }
        public int MaxConnectionsPerServer { get; set; }
        public int MaxResponseDrainSize { get; set; }
        public TimeSpan ResponseDrainTimeout { get; set; }
        public int MaxResponseHeadersLength { get; set; }
        public SslClientAuthenticationOptions SslOptions { get; set; }
        public TimeSpan PooledConnectionLifetime { get; set; }
        public TimeSpan PooledConnectionIdleTimeout { get; set; }
        public TimeSpan ConnectTimeout { get; set; }
        public TimeSpan Expect100ContinueTimeout { get; set; }
        public int InitialHttp2StreamWindowSize { get; set; }
        public TimeSpan KeepAlivePingDelay { get; set; }
        public TimeSpan KeepAlivePingTimeout { get; set; }
        public HttpKeepAlivePingPolicy KeepAlivePingPolicy { get; set; }
        public bool EnableMultipleHttp2Connections { get; set; }
        public Func<SocketsHttpConnectionContext, CancellationToken, ValueTask<Stream>> ConnectCallback { get; set; }
        public Func<SocketsHttpPlaintextStreamFilterContext, CancellationToken, ValueTask<Stream>> PlaintextStreamFilter { get; set; }
        public IDictionary<string, object> Properties { get; }
        public HeaderEncodingSelector<HttpRequestMessage> RequestHeaderEncodingSelector { get; set; }
        public HeaderEncodingSelector<HttpRequestMessage> ResponseHeaderEncodingSelector { get; set; }
        [CLSCompliant(False)]
        public DistributedContextPropagator ActivityHeadersPropagator { get; set; }
        [CLSCompliant(False)]
        public IMeterFactory MeterFactory { get; set; }

        protected override void Dispose(bool disposing);
        protected internal override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken);
        protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
    }
}
