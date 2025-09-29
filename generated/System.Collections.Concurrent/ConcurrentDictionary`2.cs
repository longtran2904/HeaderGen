#region System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.Concurrent.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace System.Collections.Concurrent
{
    [DefaultMember("Item")]
    public class ConcurrentDictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>
    {
        public ConcurrentDictionary();
        public ConcurrentDictionary(int concurrencyLevel, int capacity);
        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection);
        public ConcurrentDictionary(IEqualityComparer<TKey> comparer);
        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer);
        public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer);
        public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer);

        public TValue this[TKey key] { get; set; }
        public IEqualityComparer<TKey> Comparer { get; }
        public int Count { get; }
        public bool IsEmpty { get; }
        public ICollection<TKey> Keys { get; }
        public ICollection<TValue> Values { get; }

        public bool TryAdd(TKey key, TValue value);
        public bool ContainsKey(TKey key);
        public bool TryRemove(TKey key, out TValue value);
        public bool TryRemove(KeyValuePair<TKey, TValue> item);
        public bool TryGetValue(TKey key, out TValue value);
        public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue);
        public void Clear();
        public KeyValuePair<TKey, TValue>[] ToArray();
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory);
        public TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument);
        public TValue GetOrAdd(TKey key, TValue value);
        public TValue AddOrUpdate<TArg>(TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument);
        public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory);
        public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory);
    }
}
