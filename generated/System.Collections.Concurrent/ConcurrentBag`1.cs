#region System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.Concurrent.dll
#endregion

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public class ConcurrentBag<T> : ICollection, IEnumerable, IEnumerable<T>, IProducerConsumerCollection<T>, IReadOnlyCollection<T>
    {

        public ConcurrentBag();
        public ConcurrentBag(IEnumerable<T> collection);

        public int Count { get; }
        public bool IsEmpty { get; }

        public void Add(T item);
        public bool TryTake(out T result);
        public bool TryPeek(out T result);
        public void CopyTo(T[] array, int index);
        public T[] ToArray();
        public void Clear();
        public IEnumerator<T> GetEnumerator();
    }
}
