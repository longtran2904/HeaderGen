#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace System.Collections.ObjectModel
{
    [DefaultMember("Item")]
    public class ReadOnlyCollection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>
    {
        public ReadOnlyCollection(IList<T> list);

        public T this[int index] { get; }
        public static ReadOnlyCollection<T> Empty { get; }
        public int Count { get; }
        protected IList<T> Items { get; }

        public bool Contains(T value);
        public void CopyTo(T[] array, int index);
        public IEnumerator<T> GetEnumerator();
        public int IndexOf(T value);
    }
}
