#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Net.Http
{
    public sealed class HttpRequestOptions : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IEnumerable, IEnumerable<KeyValuePair<string, object>>, IReadOnlyCollection<KeyValuePair<string, object>>, IReadOnlyDictionary<string, object>
    {

        public HttpRequestOptions();

        public bool TryGetValue<TValue>(HttpRequestOptionsKey<TValue> key, out TValue value);
        public void Set<TValue>(HttpRequestOptionsKey<TValue> key, TValue value);
    }
}
