#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System
{
    [DefaultMember("Item")]
    public readonly struct ArraySegment<T> : ICollection<T>, IEnumerable, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>
    {
        public ArraySegment(T[] array);
        public ArraySegment(T[] array, int offset, int count);

        public T this[int index] { get; set; }
        public static ArraySegment<T> Empty { get; }
        public T[] Array { get; }
        public int Offset { get; }
        public int Count { get; }

        public Enumerator GetEnumerator();
        public override int GetHashCode();
        public void CopyTo(T[] destination);
        public void CopyTo(T[] destination, int destinationIndex);
        public void CopyTo(ArraySegment<T> destination);
        public override bool Equals(object obj);
        public bool Equals(ArraySegment<T> obj);
        public ArraySegment<T> Slice(int index);
        public ArraySegment<T> Slice(int index, int count);
        public T[] ToArray();

        public static bool operator ==(ArraySegment<T> a, ArraySegment<T> b);
        public static bool operator !=(ArraySegment<T> a, ArraySegment<T> b);

        public static implicit operator ArraySegment<T>(T[] array);

        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {
            public T Current { get; }

            public bool MoveNext();
            public void Dispose();
        }
    }
}
