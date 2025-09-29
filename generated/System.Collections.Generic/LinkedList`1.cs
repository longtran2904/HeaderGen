#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    public class LinkedList<T> : ICollection, ICollection<T>, IDeserializationCallback, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>, ISerializable
    {
        public LinkedList();
        public LinkedList(IEnumerable<T> collection);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected LinkedList(SerializationInfo info, StreamingContext context);

        public int Count { get; }
        public LinkedListNode<T> First { get; }
        public LinkedListNode<T> Last { get; }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value);
        public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode);
        public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value);
        public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode);
        public LinkedListNode<T> AddFirst(T value);
        public void AddFirst(LinkedListNode<T> node);
        public LinkedListNode<T> AddLast(T value);
        public void AddLast(LinkedListNode<T> node);
        public void Clear();
        public bool Contains(T value);
        public void CopyTo(T[] array, int index);
        public LinkedListNode<T> Find(T value);
        public LinkedListNode<T> FindLast(T value);
        public Enumerator GetEnumerator();
        public bool Remove(T value);
        public void Remove(LinkedListNode<T> node);
        public void RemoveFirst();
        public void RemoveLast();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public virtual void OnDeserialization(object sender);

        public struct Enumerator : IDeserializationCallback, IDisposable, IEnumerator, IEnumerator<T>, ISerializable
        {
            public T Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
    }
}
