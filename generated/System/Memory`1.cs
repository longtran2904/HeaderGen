#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Buffers;
using System.ComponentModel;

namespace System
{
    public readonly struct Memory<T> : IEquatable<Memory<T>>
    {
        public Memory(T[] array);
        public Memory(T[] array, int start, int length);

        public static Memory<T> Empty { get; }
        public int Length { get; }
        public bool IsEmpty { get; }
        public Span<T> Span { get; }

        public override string ToString();
        public Memory<T> Slice(int start);
        public Memory<T> Slice(int start, int length);
        public void CopyTo(Memory<T> destination);
        public bool TryCopyTo(Memory<T> destination);
        public MemoryHandle Pin();
        public T[] ToArray();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj);
        public bool Equals(Memory<T> other);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode();

        public static implicit operator Memory<T>(T[] array);
        public static implicit operator Memory<T>(ArraySegment<T> segment);
        public static implicit operator ReadOnlyMemory<T>(Memory<T> memory);
    }
}
