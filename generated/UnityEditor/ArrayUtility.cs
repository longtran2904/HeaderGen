#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor
{
    public static class ArrayUtility
    {
        public static void Add<T>(ref T[] array, T item);
        public static bool ArrayEquals<T>(T[] lhs, T[] rhs);
        public static bool ArrayReferenceEquals<T>(T[] lhs, T[] rhs);
        public static void AddRange<T>(ref T[] array, T[] items);
        public static void Insert<T>(ref T[] array, int index, T item);
        public static void Remove<T>(ref T[] array, T item);
        public static List<T> FindAll<T>(T[] array, Predicate<T> match);
        public static T Find<T>(T[] array, Predicate<T> match);
        public static int FindIndex<T>(T[] array, Predicate<T> match);
        public static int IndexOf<T>(T[] array, T value);
        public static int LastIndexOf<T>(T[] array, T value);
        public static void RemoveAt<T>(ref T[] array, int index);
        public static bool Contains<T>(T[] array, T item);
        public static void Clear<T>(ref T[] array);
    }
}
