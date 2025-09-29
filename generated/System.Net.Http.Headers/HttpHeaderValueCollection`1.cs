#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable, IEnumerable<T> where T : class
    {

        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(T item);
        public void ParseAdd(string input);
        public bool TryParseAdd(string input);
        public void Clear();
        public bool Contains(T item);
        public void CopyTo(T[] array, int arrayIndex);
        public bool Remove(T item);
        public IEnumerator<T> GetEnumerator();
        public override string ToString();
    }
}
