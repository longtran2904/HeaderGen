#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace System.Collections.ObjectModel
{
    [DefaultMember("Item")]
    public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
    {

        protected KeyedCollection();
        protected KeyedCollection(IEqualityComparer<TKey> comparer);
        protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold);

        public TItem this[TKey key] { get; }
        public IEqualityComparer<TKey> Comparer { get; }
        protected IDictionary<TKey, TItem> Dictionary { get; }

        public bool Contains(TKey key);
        public bool TryGetValue(TKey key, out TItem item);
        public bool Remove(TKey key);
        protected void ChangeItemKey(TItem item, TKey newKey);
        protected override void ClearItems();
        protected abstract TKey GetKeyForItem(TItem item);
        protected override void InsertItem(int index, TItem item);
        protected override void RemoveItem(int index);
        protected override void SetItem(int index, TItem item);
    }
}
