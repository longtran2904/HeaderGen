#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http
{
    public enum HttpRequestError
    {
        Unknown = 0,
        NameResolutionError = 1,
        ConnectionError = 2,
        SecureConnectionError = 3,
        HttpProtocolError = 4,
        ExtendedConnectNotSupported = 5,
        VersionNegotiationError = 6,
        UserAuthenticationError = 7,
        ProxyTunnelError = 8,
        InvalidResponse = 9,
        ResponseEnded = 10,
        ConfigurationLimitExceeded = 11
    }
}
