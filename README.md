# HeaderGen

HeaderGen is a small C# library for generating header-like files that list a type’s members and their signatures. It’s inspired by Visual Studio’s metadata view: given a compiled .NET assembly, it produces the same API surface you’d see when you press “Go To Definition” on a symbol without source code.

## Usage
`HeaderGen.cs` is the main library. It consists of a small `Utils` helper class, and the `HeaderGen` class contains all the necessary API with comments.

`DLLTest.cs` is just a collection of all the edge cases I found.

`Program.cs` is a small sample program that iterates through all the current domain's assemblies, plus the `DLLTest` assembly, and puts all the result files into the `generated` folder.

## Examples
Here's an example of a generated file:
```
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
```
