#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Collections.Generic
{
    [DefaultMember("Item")]
    public class List<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>
    {

        public List();
        public List(int capacity);
        public List(IEnumerable<T> collection);

        public T this[int index] { get; set; }
        public int Capacity { get; set; }
        public int Count { get; }

        public void Add(T item);
        public void AddRange(IEnumerable<T> collection);
        public ReadOnlyCollection<T> AsReadOnly();
        public int BinarySearch(int index, int count, T item, IComparer<T> comparer);
        public int BinarySearch(T item);
        public int BinarySearch(T item, IComparer<T> comparer);
        public void Clear();
        public bool Contains(T item);
        public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter);
        public void CopyTo(T[] array);
        public void CopyTo(int index, T[] array, int arrayIndex, int count);
        public void CopyTo(T[] array, int arrayIndex);
        public int EnsureCapacity(int capacity);
        public bool Exists(Predicate<T> match);
        public T Find(Predicate<T> match);
        public List<T> FindAll(Predicate<T> match);
        public int FindIndex(Predicate<T> match);
        public int FindIndex(int startIndex, Predicate<T> match);
        public int FindIndex(int startIndex, int count, Predicate<T> match);
        public T FindLast(Predicate<T> match);
        public int FindLastIndex(Predicate<T> match);
        public int FindLastIndex(int startIndex, Predicate<T> match);
        public int FindLastIndex(int startIndex, int count, Predicate<T> match);
        public void ForEach(Action<T> action);
        public Enumerator GetEnumerator();
        public List<T> GetRange(int index, int count);
        public List<T> Slice(int start, int length);
        public int IndexOf(T item);
        public int IndexOf(T item, int index);
        public int IndexOf(T item, int index, int count);
        public void Insert(int index, T item);
        public void InsertRange(int index, IEnumerable<T> collection);
        public int LastIndexOf(T item);
        public int LastIndexOf(T item, int index);
        public int LastIndexOf(T item, int index, int count);
        public bool Remove(T item);
        public int RemoveAll(Predicate<T> match);
        public void RemoveAt(int index);
        public void RemoveRange(int index, int count);
        public void Reverse();
        public void Reverse(int index, int count);
        public void Sort();
        public void Sort(IComparer<T> comparer);
        public void Sort(int index, int count, IComparer<T> comparer);
        public void Sort(Comparison<T> comparison);
        public T[] ToArray();
        public void TrimExcess();
        public bool TrueForAll(Predicate<T> match);
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {

            public T Current { get; }

            public void Dispose();
            public bool MoveNext();
        }
    }
}
