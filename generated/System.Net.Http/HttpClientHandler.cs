#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Runtime.Versioning;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class HttpClientHandler : HttpMessageHandler
    {
        public HttpClientHandler();

        public virtual bool SupportsAutomaticDecompression { get; }
        public virtual bool SupportsProxy { get; }
        public virtual bool SupportsRedirectConfiguration { get; }
        [CLSCompliant(False)]
        public IMeterFactory MeterFactory { get; set; }
        [UnsupportedOSPlatform("browser")]
        public bool UseCookies { get; set; }
        [UnsupportedOSPlatform("browser")]
        public CookieContainer CookieContainer { get; set; }
        [UnsupportedOSPlatform("browser")]
        public DecompressionMethods AutomaticDecompression { get; set; }
        [UnsupportedOSPlatform("browser")]
        public bool UseProxy { get; set; }
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public IWebProxy Proxy { get; set; }
        [UnsupportedOSPlatform("browser")]
        public ICredentials DefaultProxyCredentials { get; set; }
        [UnsupportedOSPlatform("browser")]
        public bool PreAuthenticate { get; set; }
        [UnsupportedOSPlatform("browser")]
        public bool UseDefaultCredentials { get; set; }
        [UnsupportedOSPlatform("browser")]
        public ICredentials Credentials { get; set; }
        public bool AllowAutoRedirect { get; set; }
        [UnsupportedOSPlatform("browser")]
        public int MaxAutomaticRedirections { get; set; }
        [UnsupportedOSPlatform("browser")]
        public int MaxConnectionsPerServer { get; set; }
        public long MaxRequestContentBufferSize { get; set; }
        [UnsupportedOSPlatform("browser")]
        public int MaxResponseHeadersLength { get; set; }
        public ClientCertificateOption ClientCertificateOptions { get; set; }
        [UnsupportedOSPlatform("browser")]
        public X509CertificateCollection ClientCertificates { get; }
        [UnsupportedOSPlatform("browser")]
        public Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> ServerCertificateCustomValidationCallback { get; set; }
        [UnsupportedOSPlatform("browser")]
        public bool CheckCertificateRevocationList { get; set; }
        [UnsupportedOSPlatform("browser")]
        public SslProtocols SslProtocols { get; set; }
        public IDictionary<string, object> Properties { get; }
        [UnsupportedOSPlatform("browser")]
        public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> DangerousAcceptAnyServerCertificateValidator { get; }

        protected override void Dispose(bool disposing);
        [UnsupportedOSPlatform("browser")]
        protected internal override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken);
        protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
    }
}
