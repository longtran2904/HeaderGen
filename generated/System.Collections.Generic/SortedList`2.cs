#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

using System.Reflection;

namespace System.Collections.Generic
{
    [DefaultMember("Item")]
    public class SortedList<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>
    {

        public SortedList();
        public SortedList(int capacity);
        public SortedList(IComparer<TKey> comparer);
        public SortedList(int capacity, IComparer<TKey> comparer);
        public SortedList(IDictionary<TKey, TValue> dictionary);
        public SortedList(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer);

        public TValue this[TKey key] { get; set; }
        public int Capacity { get; set; }
        public IComparer<TKey> Comparer { get; }
        public int Count { get; }
        public IList<TKey> Keys { get; }
        public IList<TValue> Values { get; }

        public void Add(TKey key, TValue value);
        public void Clear();
        public bool ContainsKey(TKey key);
        public bool ContainsValue(TValue value);
        public TValue GetValueAtIndex(int index);
        public void SetValueAtIndex(int index, TValue value);
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
        public TKey GetKeyAtIndex(int index);
        public int IndexOfKey(TKey key);
        public int IndexOfValue(TValue value);
        public bool TryGetValue(TKey key, out TValue value);
        public void RemoveAt(int index);
        public bool Remove(TKey key);
        public void TrimExcess();
        [DefaultMember("Item")]
        public sealed class KeyList : ICollection, ICollection<TKey>, IEnumerable, IEnumerable<TKey>, IList<TKey>
        {

            public TKey this[int index] { get; set; }
            public int Count { get; }
            public bool IsReadOnly { get; }

            public void Add(TKey key);
            public void Clear();
            public bool Contains(TKey key);
            public void CopyTo(TKey[] array, int arrayIndex);
            public void Insert(int index, TKey value);
            public IEnumerator<TKey> GetEnumerator();
            public int IndexOf(TKey key);
            public bool Remove(TKey key);
            public void RemoveAt(int index);
        }
        [DefaultMember("Item")]
        public sealed class ValueList : ICollection, ICollection<TValue>, IEnumerable, IEnumerable<TValue>, IList<TValue>
        {

            public TValue this[int index] { get; set; }
            public int Count { get; }
            public bool IsReadOnly { get; }

            public void Add(TValue key);
            public void Clear();
            public bool Contains(TValue value);
            public void CopyTo(TValue[] array, int arrayIndex);
            public void Insert(int index, TValue value);
            public IEnumerator<TValue> GetEnumerator();
            public int IndexOf(TValue value);
            public bool Remove(TValue value);
            public void RemoveAt(int index);
        }
    }
}
