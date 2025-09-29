#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public class ConcurrentQueue<T> : ICollection, IEnumerable, IEnumerable<T>, IProducerConsumerCollection<T>, IReadOnlyCollection<T>
    {

        public ConcurrentQueue();
        public ConcurrentQueue(IEnumerable<T> collection);

        public bool IsEmpty { get; }
        public int Count { get; }

        public T[] ToArray();
        public void CopyTo(T[] array, int index);
        public IEnumerator<T> GetEnumerator();
        public void Enqueue(T item);
        public bool TryDequeue(out T result);
        public bool TryPeek(out T result);
        public void Clear();
    }
}
