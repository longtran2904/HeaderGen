#region System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.Concurrent.dll
#endregion

using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Threading;

namespace System.Collections.Concurrent
{
    [UnsupportedOSPlatform("browser")]
    public class BlockingCollection<T> : ICollection, IDisposable, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>
    {
        public BlockingCollection();
        public BlockingCollection(int boundedCapacity);
        public BlockingCollection(IProducerConsumerCollection<T> collection, int boundedCapacity);
        public BlockingCollection(IProducerConsumerCollection<T> collection);

        public int BoundedCapacity { get; }
        public bool IsAddingCompleted { get; }
        public bool IsCompleted { get; }
        public int Count { get; }

        public void Add(T item);
        public void Add(T item, CancellationToken cancellationToken);
        public bool TryAdd(T item);
        public bool TryAdd(T item, TimeSpan timeout);
        public bool TryAdd(T item, int millisecondsTimeout);
        public bool TryAdd(T item, int millisecondsTimeout, CancellationToken cancellationToken);
        public T Take();
        public T Take(CancellationToken cancellationToken);
        public bool TryTake(out T item);
        public bool TryTake(out T item, TimeSpan timeout);
        public bool TryTake(out T item, int millisecondsTimeout);
        public bool TryTake(out T item, int millisecondsTimeout, CancellationToken cancellationToken);
        public static int AddToAny(BlockingCollection<T>[] collections, T item);
        public static int AddToAny(BlockingCollection<T>[] collections, T item, CancellationToken cancellationToken);
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item);
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item, TimeSpan timeout);
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout);
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken cancellationToken);
        public static int TakeFromAny(BlockingCollection<T>[] collections, out T item);
        public static int TakeFromAny(BlockingCollection<T>[] collections, out T item, CancellationToken cancellationToken);
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item);
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, TimeSpan timeout);
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout);
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, CancellationToken cancellationToken);
        public void CompleteAdding();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public T[] ToArray();
        public void CopyTo(T[] array, int index);
        public IEnumerable<T> GetConsumingEnumerable();
        public IEnumerable<T> GetConsumingEnumerable(CancellationToken cancellationToken);
    }
}
