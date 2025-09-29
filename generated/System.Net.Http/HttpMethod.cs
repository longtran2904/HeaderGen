#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http
{
    public class HttpMethod : IEquatable<HttpMethod>
    {
        public HttpMethod(string method);

        public static HttpMethod Get { get; }
        public static HttpMethod Put { get; }
        public static HttpMethod Post { get; }
        public static HttpMethod Delete { get; }
        public static HttpMethod Head { get; }
        public static HttpMethod Options { get; }
        public static HttpMethod Trace { get; }
        public static HttpMethod Patch { get; }
        public static HttpMethod Connect { get; }
        public string Method { get; }

        public bool Equals(HttpMethod other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
        public static HttpMethod Parse(ReadOnlySpan<char> method);

        public static bool operator ==(HttpMethod left, HttpMethod right);
        public static bool operator !=(HttpMethod left, HttpMethod right);
    }
}
