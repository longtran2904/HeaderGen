#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    [DefaultMember("Item")]
    public class Dictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDeserializationCallback, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>, ISerializable
    {
        public Dictionary();
        public Dictionary(int capacity);
        public Dictionary(IEqualityComparer<TKey> comparer);
        public Dictionary(int capacity, IEqualityComparer<TKey> comparer);
        public Dictionary(IDictionary<TKey, TValue> dictionary);
        public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer);
        public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection);
        public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected Dictionary(SerializationInfo info, StreamingContext context);

        public TValue this[TKey key] { get; set; }
        public IEqualityComparer<TKey> Comparer { get; }
        public int Count { get; }
        public KeyCollection Keys { get; }
        public ValueCollection Values { get; }

        public void Add(TKey key, TValue value);
        public void Clear();
        public bool ContainsKey(TKey key);
        public bool ContainsValue(TValue value);
        public Enumerator GetEnumerator();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public virtual void OnDeserialization(object sender);
        public bool Remove(TKey key);
        public bool Remove(TKey key, out TValue value);
        public bool TryGetValue(TKey key, out TValue value);
        public bool TryAdd(TKey key, TValue value);
        public int EnsureCapacity(int capacity);
        public void TrimExcess();
        public void TrimExcess(int capacity);

        public struct Enumerator : IDictionaryEnumerator, IDisposable, IEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
        {
            public KeyValuePair<TKey, TValue> Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
        public sealed class KeyCollection : ICollection, ICollection<TKey>, IEnumerable, IEnumerable<TKey>, IReadOnlyCollection<TKey>
        {
            public KeyCollection(Dictionary<TKey, TValue> dictionary);

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
            public ValueCollection(Dictionary<TKey, TValue> dictionary);

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
    }
}
