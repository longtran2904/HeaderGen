#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public readonly struct HeaderStringValues : IEnumerable, IEnumerable<string>, IReadOnlyCollection<string>
    {
        public int Count { get; }

        public override string ToString();
        public Enumerator GetEnumerator();

        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<string>
        {
            public string Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
    }
}
