#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

namespace System.Collections.Generic
{
    public class Stack<T> : ICollection, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>
    {

        public Stack();
        public Stack(int capacity);
        public Stack(IEnumerable<T> collection);

        public int Count { get; }

        public void Clear();
        public bool Contains(T item);
        public void CopyTo(T[] array, int arrayIndex);
        public Enumerator GetEnumerator();
        public void TrimExcess();
        public T Peek();
        public bool TryPeek(out T result);
        public T Pop();
        public bool TryPop(out T result);
        public void Push(T item);
        public int EnsureCapacity(int capacity);
        public T[] ToArray();
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {

            public T Current { get; }

            public void Dispose();
            public bool MoveNext();
        }
    }
}
