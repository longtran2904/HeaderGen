#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Buffers;
using System.ComponentModel;

namespace System
{
    public readonly struct ReadOnlyMemory<T> : IEquatable<ReadOnlyMemory<T>>
    {
        public ReadOnlyMemory(T[] array);
        public ReadOnlyMemory(T[] array, int start, int length);

        public static ReadOnlyMemory<T> Empty { get; }
        public int Length { get; }
        public bool IsEmpty { get; }
        public ReadOnlySpan<T> Span { get; }

        public override string ToString();
        public ReadOnlyMemory<T> Slice(int start);
        public ReadOnlyMemory<T> Slice(int start, int length);
        public void CopyTo(Memory<T> destination);
        public bool TryCopyTo(Memory<T> destination);
        public MemoryHandle Pin();
        public T[] ToArray();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj);
        public bool Equals(ReadOnlyMemory<T> other);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode();

        public static implicit operator ReadOnlyMemory<T>(T[] array);
        public static implicit operator ReadOnlyMemory<T>(ArraySegment<T> segment);
    }
}
