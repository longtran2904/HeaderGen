#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Text
{
    public struct StringRuneEnumerator : IDisposable, IEnumerable, IEnumerable<Rune>, IEnumerator, IEnumerator<Rune>
    {
        public Rune Current { get; }

        public StringRuneEnumerator GetEnumerator();
        public bool MoveNext();
    }
}
