#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace System.Collections.ObjectModel
{
    [DefaultMember("Item")]
    public class Collection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>
    {

        public Collection();
        public Collection(IList<T> list);

        public T this[int index] { get; set; }
        public int Count { get; }
        protected IList<T> Items { get; }

        public void Add(T item);
        public void Clear();
        public void CopyTo(T[] array, int index);
        public bool Contains(T item);
        public IEnumerator<T> GetEnumerator();
        public int IndexOf(T item);
        public void Insert(int index, T item);
        public bool Remove(T item);
        public void RemoveAt(int index);
        protected virtual void ClearItems();
        protected virtual void InsertItem(int index, T item);
        protected virtual void RemoveItem(int index);
        protected virtual void SetItem(int index, T item);
    }
}
