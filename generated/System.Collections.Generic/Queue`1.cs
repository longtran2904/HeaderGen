#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Collections.Generic
{
    public class Queue<T> : ICollection, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>
    {

        public Queue();
        public Queue(int capacity);
        public Queue(IEnumerable<T> collection);

        public int Count { get; }

        public void Clear();
        public void CopyTo(T[] array, int arrayIndex);
        public void Enqueue(T item);
        public Enumerator GetEnumerator();
        public T Dequeue();
        public bool TryDequeue(out T result);
        public T Peek();
        public bool TryPeek(out T result);
        public bool Contains(T item);
        public T[] ToArray();
        public void TrimExcess();
        public int EnsureCapacity(int capacity);
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {

            public T Current { get; }

            public void Dispose();
            public bool MoveNext();
        }
    }
}
