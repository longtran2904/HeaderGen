#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System.Text.RegularExpressions
{
    [DefaultMember("Item")]
    public class MatchCollection : ICollection, ICollection<Match>, IEnumerable, IEnumerable<Match>, IList, IList<Match>, IReadOnlyCollection<Match>, IReadOnlyList<Match>
    {
        public virtual Match this[int i] { get; }
        public bool IsReadOnly { get; }
        public int Count { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }

        public IEnumerator GetEnumerator();
        public void CopyTo(Array array, int arrayIndex);
        public void CopyTo(Match[] array, int arrayIndex);
    }
}
