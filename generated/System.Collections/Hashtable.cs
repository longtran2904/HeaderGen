#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Collections
{
    [DefaultMember("Item")]
    public class Hashtable : ICloneable, ICollection, IDeserializationCallback, IDictionary, IEnumerable, ISerializable
    {
        public Hashtable();
        public Hashtable(int capacity);
        public Hashtable(int capacity, float loadFactor);
        public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer);
        [Obsolete("This constructor has been deprecated. Use Hashtable(IEqualityComparer) instead.")]
        public Hashtable(IHashCodeProvider hcp, IComparer comparer);
        public Hashtable(IEqualityComparer equalityComparer);
        [Obsolete("This constructor has been deprecated. Use Hashtable(int, IEqualityComparer) instead.")]
        public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer);
        public Hashtable(int capacity, IEqualityComparer equalityComparer);
        public Hashtable(IDictionary d);
        public Hashtable(IDictionary d, float loadFactor);
        [Obsolete("This constructor has been deprecated. Use Hashtable(IDictionary, IEqualityComparer) instead.")]
        public Hashtable(IDictionary d, IHashCodeProvider hcp, IComparer comparer);
        public Hashtable(IDictionary d, IEqualityComparer equalityComparer);
        [Obsolete("This constructor has been deprecated. Use Hashtable(int, float, IEqualityComparer) instead.")]
        public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer);
        [Obsolete("This constructor has been deprecated. Use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
        public Hashtable(IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer);
        public Hashtable(IDictionary d, float loadFactor, IEqualityComparer equalityComparer);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected Hashtable(SerializationInfo info, StreamingContext context);

        public virtual object this[object key] { get; set; }
        [Obsolete("Hashtable.hcp has been deprecated. Use the EqualityComparer property instead.")]
        protected IHashCodeProvider hcp { get; set; }
        [Obsolete("Hashtable.comparer has been deprecated. Use the KeyComparer properties instead.")]
        protected IComparer comparer { get; set; }
        protected IEqualityComparer EqualityComparer { get; }
        public virtual bool IsReadOnly { get; }
        public virtual bool IsFixedSize { get; }
        public virtual bool IsSynchronized { get; }
        public virtual ICollection Keys { get; }
        public virtual ICollection Values { get; }
        public virtual object SyncRoot { get; }
        public virtual int Count { get; }

        public virtual void Add(object key, object value);
        public virtual void Clear();
        public virtual object Clone();
        public virtual bool Contains(object key);
        public virtual bool ContainsKey(object key);
        public virtual bool ContainsValue(object value);
        public virtual void CopyTo(Array array, int arrayIndex);
        public virtual IDictionaryEnumerator GetEnumerator();
        protected virtual int GetHash(object key);
        protected virtual bool KeyEquals(object item, object key);
        public virtual void Remove(object key);
        public static Hashtable Synchronized(Hashtable table);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public virtual void OnDeserialization(object sender);
    }
}
