#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;

namespace System.Net.Http
{
    public sealed class SocketsHttpPlaintextStreamFilterContext
    {

        public Stream PlaintextStream { get; }
        public Version NegotiatedHttpVersion { get; }
        public HttpRequestMessage InitialRequestMessage { get; }
    }
}
