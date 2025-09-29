#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http
{
    public class HttpRequestException : Exception
    {
        public HttpRequestException();
        public HttpRequestException(string message);
        public HttpRequestException(string message, Exception inner);
        public HttpRequestException(string message, Exception inner, HttpStatusCode? statusCode);
        public HttpRequestException(HttpRequestError httpRequestError, string message = null, Exception inner = null, HttpStatusCode? statusCode = null);

        public HttpRequestError HttpRequestError { get; }
        public HttpStatusCode? StatusCode { get; }
    }
}
