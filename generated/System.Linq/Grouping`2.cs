#region System.Linq, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Linq.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
    public class Grouping<TKey, TElement> : ICollection<TElement>, IEnumerable, IEnumerable<TElement>, IGrouping<TKey, TElement>, IList<TElement>
    {

        public TKey Key { get; }

        public IEnumerator<TElement> GetEnumerator();
    }
}
