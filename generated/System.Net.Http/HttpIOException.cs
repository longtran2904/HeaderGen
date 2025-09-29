#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;

namespace System.Net.Http
{
    public class HttpIOException : IOException
    {

        public HttpIOException(HttpRequestError httpRequestError, string message = null, Exception innerException = null);

        public HttpRequestError HttpRequestError { get; }
        public override string Message { get; }
    }
}
