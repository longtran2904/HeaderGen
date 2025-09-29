#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Mono.Collections.Generic
{
    [DefaultMember("Item")]
    public class Collection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>
    {
        public Collection();
        public Collection(int capacity);
        public Collection(ICollection<T> items);

        public T this[int index] { get; set; }
        public int Count { get; }
        public int Capacity { get; set; }

        public void Add(T item);
        public bool Contains(T item);
        public int IndexOf(T item);
        public void Insert(int index, T item);
        public void RemoveAt(int index);
        public bool Remove(T item);
        public void Clear();
        public void CopyTo(T[] array, int arrayIndex);
        public T[] ToArray();
        protected virtual void OnAdd(T item, int index);
        protected virtual void OnInsert(T item, int index);
        protected virtual void OnSet(T item, int index);
        protected virtual void OnRemove(T item, int index);
        protected virtual void OnClear();
        protected void Resize(int new_size);
        public Enumerator GetEnumerator();

        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {
            public T Current { get; }

            public bool MoveNext();
            public void Reset();
            public void Dispose();
        }
    }
}
