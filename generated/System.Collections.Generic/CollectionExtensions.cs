#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.ObjectModel;

namespace System.Collections.Generic
{
    public static class CollectionExtensions
    {

        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key);
        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue);
        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value);
        public static bool Remove<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, out TValue value);
        public static ReadOnlyCollection<T> AsReadOnly<T>(this IList<T> list);
        public static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary);
        public static void AddRange<T>(this List<T> list, ReadOnlySpan<T> source);
        public static void InsertRange<T>(this List<T> list, int index, ReadOnlySpan<T> source);
        public static void CopyTo<T>(this List<T> list, Span<T> destination);
    }
}
