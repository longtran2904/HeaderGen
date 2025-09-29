#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    public class SortedSet<T> : ICollection, ICollection<T>, IDeserializationCallback, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, ISerializable, ISet<T>
    {
        public SortedSet();
        public SortedSet(IComparer<T> comparer);
        public SortedSet(IEnumerable<T> collection);
        public SortedSet(IEnumerable<T> collection, IComparer<T> comparer);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected SortedSet(SerializationInfo info, StreamingContext context);

        public int Count { get; }
        public IComparer<T> Comparer { get; }
        public T Min { get; }
        public T Max { get; }

        public bool Add(T item);
        public bool Remove(T item);
        public virtual void Clear();
        public virtual bool Contains(T item);
        public void CopyTo(T[] array);
        public void CopyTo(T[] array, int index);
        public void CopyTo(T[] array, int index, int count);
        public Enumerator GetEnumerator();
        public static IEqualityComparer<SortedSet<T>> CreateSetComparer();
        public static IEqualityComparer<SortedSet<T>> CreateSetComparer(IEqualityComparer<T> memberEqualityComparer);
        public void UnionWith(IEnumerable<T> other);
        public virtual void IntersectWith(IEnumerable<T> other);
        public void ExceptWith(IEnumerable<T> other);
        public void SymmetricExceptWith(IEnumerable<T> other);
        public bool IsSubsetOf(IEnumerable<T> other);
        public bool IsProperSubsetOf(IEnumerable<T> other);
        public bool IsSupersetOf(IEnumerable<T> other);
        public bool IsProperSupersetOf(IEnumerable<T> other);
        public bool SetEquals(IEnumerable<T> other);
        public bool Overlaps(IEnumerable<T> other);
        public int RemoveWhere(Predicate<T> match);
        public IEnumerable<T> Reverse();
        public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue);
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        protected virtual void OnDeserialization(object sender);
        public bool TryGetValue(T equalValue, out T actualValue);

        public struct Enumerator : IDeserializationCallback, IDisposable, IEnumerator, IEnumerator<T>, ISerializable
        {
            public T Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
    }
}
