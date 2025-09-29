#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Collections
{
    [DefaultMember("Item")]
    public class ListDictionaryInternal : ICollection, IDictionary, IEnumerable
    {
        public ListDictionaryInternal();

        public object this[object key] { get; set; }
        public int Count { get; }
        public ICollection Keys { get; }
        public bool IsReadOnly { get; }
        public bool IsFixedSize { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
        public ICollection Values { get; }

        public void Add(object key, object value);
        public void Clear();
        public bool Contains(object key);
        public void CopyTo(Array array, int index);
        public IDictionaryEnumerator GetEnumerator();
        public void Remove(object key);
    }
}
