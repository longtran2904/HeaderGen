#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public abstract class HttpHeaders : IEnumerable, IEnumerable<KeyValuePair<string, IEnumerable<string>>>
    {
        protected HttpHeaders();

        public HttpHeadersNonValidated NonValidated { get; }

        public void Add(string name, string value);
        public void Add(string name, IEnumerable<string> values);
        public bool TryAddWithoutValidation(string name, string value);
        public bool TryAddWithoutValidation(string name, IEnumerable<string> values);
        public IEnumerable<string> GetValues(string name);
        public bool TryGetValues(string name, out IEnumerable<string> values);
        public bool Contains(string name);
        public override string ToString();
        public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator();
        public bool Remove(string name);
        public void Clear();
    }
}
