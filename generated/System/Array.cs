#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System
{
    public abstract class Array : ICloneable, ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable
    {
        public int Length { get; }
        public long LongLength { get; }
        public int Rank { get; }
        public object SyncRoot { get; }
        public bool IsReadOnly { get; }
        public bool IsFixedSize { get; }
        public bool IsSynchronized { get; }
        public static int MaxLength { get; }

        public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length);
        public static void Clear(Array array);
        public static void Clear(Array array, int index, int length);
        public int GetLength(int dimension);
        public int GetUpperBound(int dimension);
        public int GetLowerBound(int dimension);
        public void Initialize();
        public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array);
        public static void Resize<T>(ref T[] array, int newSize);
        public static Array CreateInstance(Type elementType, int length);
        public static Array CreateInstance(Type elementType, int length1, int length2);
        public static Array CreateInstance(Type elementType, int length1, int length2, int length3);
        public static Array CreateInstance(Type elementType, params int[] lengths);
        public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds);
        public static Array CreateInstance(Type elementType, params long[] lengths);
        public static void Copy(Array sourceArray, Array destinationArray, long length);
        public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length);
        public static void Copy(Array sourceArray, Array destinationArray, int length);
        public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length);
        public object GetValue(params int[] indices);
        public object GetValue(int index);
        public object GetValue(int index1, int index2);
        public object GetValue(int index1, int index2, int index3);
        public void SetValue(object value, int index);
        public void SetValue(object value, int index1, int index2);
        public void SetValue(object value, int index1, int index2, int index3);
        public void SetValue(object value, params int[] indices);
        public object GetValue(long index);
        public object GetValue(long index1, long index2);
        public object GetValue(long index1, long index2, long index3);
        public object GetValue(params long[] indices);
        public void SetValue(object value, long index);
        public void SetValue(object value, long index1, long index2);
        public void SetValue(object value, long index1, long index2, long index3);
        public void SetValue(object value, params long[] indices);
        public long GetLongLength(int dimension);
        public object Clone();
        public static int BinarySearch(Array array, object value);
        public static int BinarySearch(Array array, int index, int length, object value);
        public static int BinarySearch(Array array, object value, IComparer comparer);
        public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer);
        public static int BinarySearch<T>(T[] array, T value);
        public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer);
        public static int BinarySearch<T>(T[] array, int index, int length, T value);
        public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer);
        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter);
        public void CopyTo(Array array, int index);
        public void CopyTo(Array array, long index);
        public static T[] Empty<T>();
        public static bool Exists<T>(T[] array, Predicate<T> match);
        public static void Fill<T>(T[] array, T value);
        public static void Fill<T>(T[] array, T value, int startIndex, int count);
        public static T Find<T>(T[] array, Predicate<T> match);
        public static T[] FindAll<T>(T[] array, Predicate<T> match);
        public static int FindIndex<T>(T[] array, Predicate<T> match);
        public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match);
        public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match);
        public static T FindLast<T>(T[] array, Predicate<T> match);
        public static int FindLastIndex<T>(T[] array, Predicate<T> match);
        public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match);
        public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match);
        public static void ForEach<T>(T[] array, Action<T> action);
        public static int IndexOf(Array array, object value);
        public static int IndexOf(Array array, object value, int startIndex);
        public static int IndexOf(Array array, object value, int startIndex, int count);
        public static int IndexOf<T>(T[] array, T value);
        public static int IndexOf<T>(T[] array, T value, int startIndex);
        public static int IndexOf<T>(T[] array, T value, int startIndex, int count);
        public static int LastIndexOf(Array array, object value);
        public static int LastIndexOf(Array array, object value, int startIndex);
        public static int LastIndexOf(Array array, object value, int startIndex, int count);
        public static int LastIndexOf<T>(T[] array, T value);
        public static int LastIndexOf<T>(T[] array, T value, int startIndex);
        public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count);
        public static void Reverse(Array array);
        public static void Reverse(Array array, int index, int length);
        public static void Reverse<T>(T[] array);
        public static void Reverse<T>(T[] array, int index, int length);
        public static void Sort(Array array);
        public static void Sort(Array keys, Array items);
        public static void Sort(Array array, int index, int length);
        public static void Sort(Array keys, Array items, int index, int length);
        public static void Sort(Array array, IComparer comparer);
        public static void Sort(Array keys, Array items, IComparer comparer);
        public static void Sort(Array array, int index, int length, IComparer comparer);
        public static void Sort(Array keys, Array items, int index, int length, IComparer comparer);
        public static void Sort<T>(T[] array);
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items);
        public static void Sort<T>(T[] array, int index, int length);
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length);
        public static void Sort<T>(T[] array, IComparer<T> comparer);
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer);
        public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer);
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer);
        public static void Sort<T>(T[] array, Comparison<T> comparison);
        public static bool TrueForAll<T>(T[] array, Predicate<T> match);
        public IEnumerator GetEnumerator();
    }
}
