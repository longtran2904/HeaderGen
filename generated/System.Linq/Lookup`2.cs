#region System.Linq, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Linq.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System.Linq
{
    [DefaultMember("Item")]
    public class Lookup<TKey, TElement> : IEnumerable, IEnumerable<IGrouping<TKey, TElement>>, IIListProvider<IGrouping<TKey, TElement>>, ILookup<TKey, TElement>
    {
        public IEnumerable<TElement> this[TKey key] { get; }
        public int Count { get; }

        public bool Contains(TKey key);
        public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator();
        public IEnumerable<TResult> ApplyResultSelector<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector);
    }
}
