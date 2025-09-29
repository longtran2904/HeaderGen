#region System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.Concurrent.dll
#endregion

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public class ConcurrentStack<T> : ICollection, IEnumerable, IEnumerable<T>, IProducerConsumerCollection<T>, IReadOnlyCollection<T>
    {

        public ConcurrentStack();
        public ConcurrentStack(IEnumerable<T> collection);

        public bool IsEmpty { get; }
        public int Count { get; }

        public void Clear();
        public void CopyTo(T[] array, int index);
        public void Push(T item);
        public void PushRange(T[] items);
        public void PushRange(T[] items, int startIndex, int count);
        public bool TryPeek(out T result);
        public bool TryPop(out T result);
        public int TryPopRange(T[] items);
        public int TryPopRange(T[] items, int startIndex, int count);
        public T[] ToArray();
        public IEnumerator<T> GetEnumerator();
    }
}
