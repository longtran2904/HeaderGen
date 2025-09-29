#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>> where TKey : class where TValue : class
    {

        public ConditionalWeakTable();

        public bool TryGetValue(TKey key, out TValue value);
        public void Add(TKey key, TValue value);
        public bool TryAdd(TKey key, TValue value);
        public void AddOrUpdate(TKey key, TValue value);
        public bool Remove(TKey key);
        public void Clear();
        public TValue GetValue(TKey key, CreateValueCallback createValueCallback);
        public TValue GetOrCreateValue(TKey key);
        public delegate TValue CreateValueCallback(TKey key);
    }
}
