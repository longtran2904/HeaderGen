#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

namespace System.Collections.Generic
{
    public sealed class LinkedListNode<T>
    {

        public LinkedListNode(T value);

        public LinkedList<T> List { get; }
        public LinkedListNode<T> Next { get; }
        public LinkedListNode<T> Previous { get; }
        public T Value { get; set; }
        public ref T ValueRef { get; }
    }
}
