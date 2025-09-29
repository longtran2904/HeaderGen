#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

using System.Reflection;

namespace System.Collections.Generic
{
    [DefaultMember("Item")]
    public class SortedDictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>
    {

        public SortedDictionary();
        public SortedDictionary(IDictionary<TKey, TValue> dictionary);
        public SortedDictionary(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer);
        public SortedDictionary(IComparer<TKey> comparer);

        public TValue this[TKey key] { get; set; }
        public int Count { get; }
        public IComparer<TKey> Comparer { get; }
        public KeyCollection Keys { get; }
        public ValueCollection Values { get; }

        public void Add(TKey key, TValue value);
        public void Clear();
        public bool ContainsKey(TKey key);
        public bool ContainsValue(TValue value);
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index);
        public Enumerator GetEnumerator();
        public bool Remove(TKey key);
        public bool TryGetValue(TKey key, out TValue value);
        public struct Enumerator : IDictionaryEnumerator, IDisposable, IEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
        {

            public KeyValuePair<TKey, TValue> Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
        public sealed class KeyCollection : ICollection, ICollection<TKey>, IEnumerable, IEnumerable<TKey>, IReadOnlyCollection<TKey>
        {

            public KeyCollection(SortedDictionary<TKey, TValue> dictionary);

            public int Count { get; }

            public Enumerator GetEnumerator();
            public void CopyTo(TKey[] array, int index);
            public bool Contains(TKey item);
            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
            {

                public TKey Current { get; }

                public void Dispose();
                public bool MoveNext();
            }
        }
        public sealed class ValueCollection : ICollection, ICollection<TValue>, IEnumerable, IEnumerable<TValue>, IReadOnlyCollection<TValue>
        {

            public ValueCollection(SortedDictionary<TKey, TValue> dictionary);

            public int Count { get; }

            public Enumerator GetEnumerator();
            public void CopyTo(TValue[] array, int index);
            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
            {

                public TValue Current { get; }

                public void Dispose();
                public bool MoveNext();
            }
        }
        public sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
        {

            public KeyValuePairComparer(IComparer<TKey> keyComparer);

            public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y);
            public override bool Equals(object obj);
            public override int GetHashCode();
        }
    }
}
