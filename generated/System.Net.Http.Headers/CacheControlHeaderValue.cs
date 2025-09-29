#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public class CacheControlHeaderValue : ICloneable
    {
        public CacheControlHeaderValue();

        public bool NoCache { get; set; }
        public ICollection<string> NoCacheHeaders { get; }
        public bool NoStore { get; set; }
        public TimeSpan? MaxAge { get; set; }
        public TimeSpan? SharedMaxAge { get; set; }
        public bool MaxStale { get; set; }
        public TimeSpan? MaxStaleLimit { get; set; }
        public TimeSpan? MinFresh { get; set; }
        public bool NoTransform { get; set; }
        public bool OnlyIfCached { get; set; }
        public bool Public { get; set; }
        public bool Private { get; set; }
        public ICollection<string> PrivateHeaders { get; }
        public bool MustRevalidate { get; set; }
        public bool ProxyRevalidate { get; set; }
        public ICollection<NameValueHeaderValue> Extensions { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static CacheControlHeaderValue Parse(string input);
        public static bool TryParse(string input, out CacheControlHeaderValue parsedValue);
    }
}
