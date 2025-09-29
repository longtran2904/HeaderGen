#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Metrics
{
    public sealed class HttpMetricsEnrichmentContext
    {
        public HttpRequestMessage Request { get; }
        public HttpResponseMessage Response { get; }
        public Exception Exception { get; }

        public void AddCustomTag(string name, object value);
        public static void AddCallback(HttpRequestMessage request, Action<HttpMetricsEnrichmentContext> callback);
    }
}
