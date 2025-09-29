#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    public class HashSet<T> : ICollection<T>, IDeserializationCallback, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, ISerializable, ISet<T>
    {

        public HashSet();
        public HashSet(IEqualityComparer<T> comparer);
        public HashSet(int capacity);
        public HashSet(IEnumerable<T> collection);
        public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer);
        public HashSet(int capacity, IEqualityComparer<T> comparer);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected HashSet(SerializationInfo info, StreamingContext context);

        public int Count { get; }
        public IEqualityComparer<T> Comparer { get; }

        public void Clear();
        public bool Contains(T item);
        public bool Remove(T item);
        public Enumerator GetEnumerator();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public virtual void OnDeserialization(object sender);
        public bool Add(T item);
        public bool TryGetValue(T equalValue, out T actualValue);
        public void UnionWith(IEnumerable<T> other);
        public void IntersectWith(IEnumerable<T> other);
        public void ExceptWith(IEnumerable<T> other);
        public void SymmetricExceptWith(IEnumerable<T> other);
        public bool IsSubsetOf(IEnumerable<T> other);
        public bool IsProperSubsetOf(IEnumerable<T> other);
        public bool IsSupersetOf(IEnumerable<T> other);
        public bool IsProperSupersetOf(IEnumerable<T> other);
        public bool Overlaps(IEnumerable<T> other);
        public bool SetEquals(IEnumerable<T> other);
        public void CopyTo(T[] array);
        public void CopyTo(T[] array, int arrayIndex);
        public void CopyTo(T[] array, int arrayIndex, int count);
        public int RemoveWhere(Predicate<T> match);
        public int EnsureCapacity(int capacity);
        public void TrimExcess();
        public static IEqualityComparer<HashSet<T>> CreateSetComparer();
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {

            public T Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
    }
}
