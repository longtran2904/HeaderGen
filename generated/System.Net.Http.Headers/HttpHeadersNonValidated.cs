#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System.Net.Http.Headers
{
    [DefaultMember("Item")]
    public readonly struct HttpHeadersNonValidated : IEnumerable, IEnumerable<KeyValuePair<string, HeaderStringValues>>, IReadOnlyCollection<KeyValuePair<string, HeaderStringValues>>, IReadOnlyDictionary<string, HeaderStringValues>
    {

        public HeaderStringValues this[string headerName] { get; }
        public int Count { get; }

        public bool Contains(string headerName);
        public bool TryGetValues(string headerName, out HeaderStringValues values);
        public Enumerator GetEnumerator();
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<KeyValuePair<string, HeaderStringValues>>
        {

            public KeyValuePair<string, HeaderStringValues> Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
    }
}
