#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

namespace System.Collections.Generic
{
    public class PriorityQueue<TElement, TPriority>
    {
        public PriorityQueue();
        public PriorityQueue(int initialCapacity);
        public PriorityQueue(IComparer<TPriority> comparer);
        public PriorityQueue(int initialCapacity, IComparer<TPriority> comparer);
        public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items);
        public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items, IComparer<TPriority> comparer);

        public int Count { get; }
        public IComparer<TPriority> Comparer { get; }
        public UnorderedItemsCollection UnorderedItems { get; }

        public void Enqueue(TElement element, TPriority priority);
        public TElement Peek();
        public TElement Dequeue();
        public TElement DequeueEnqueue(TElement element, TPriority priority);
        public bool TryDequeue(out TElement element, out TPriority priority);
        public bool TryPeek(out TElement element, out TPriority priority);
        public TElement EnqueueDequeue(TElement element, TPriority priority);
        public void EnqueueRange(IEnumerable<(TElement Element, TPriority Priority)> items);
        public void EnqueueRange(IEnumerable<TElement> elements, TPriority priority);
        public void Clear();
        public int EnsureCapacity(int capacity);
        public void TrimExcess();

        public sealed class UnorderedItemsCollection : ICollection, IEnumerable, IEnumerable<(TElement, TPriority)>, IReadOnlyCollection<(TElement, TPriority)>
        {
            public int Count { get; }

            public Enumerator GetEnumerator();

            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<(TElement, TPriority)>
            {
                public (TElement Element, TPriority Priority) Current { get; }

                public void Dispose();
                public bool MoveNext();
            }
        }
    }
}
