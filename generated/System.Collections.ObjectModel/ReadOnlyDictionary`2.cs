#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace System.Collections.ObjectModel
{
    [DefaultMember("Item")]
    public class ReadOnlyDictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>
    {
        public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary);

        public TValue this[TKey key] { get; }
        public static ReadOnlyDictionary<TKey, TValue> Empty { get; }
        protected IDictionary<TKey, TValue> Dictionary { get; }
        public KeyCollection Keys { get; }
        public ValueCollection Values { get; }
        public int Count { get; }

        public bool ContainsKey(TKey key);
        public bool TryGetValue(TKey key, out TValue value);
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();

        public sealed class KeyCollection : ICollection, ICollection<TKey>, IEnumerable, IEnumerable<TKey>, IReadOnlyCollection<TKey>
        {
            public int Count { get; }

            public bool Contains(TKey item);
            public void CopyTo(TKey[] array, int arrayIndex);
            public IEnumerator<TKey> GetEnumerator();
        }
        public sealed class ValueCollection : ICollection, ICollection<TValue>, IEnumerable, IEnumerable<TValue>, IReadOnlyCollection<TValue>
        {
            public int Count { get; }

            public void CopyTo(TValue[] array, int arrayIndex);
            public IEnumerator<TValue> GetEnumerator();
        }
    }
}
