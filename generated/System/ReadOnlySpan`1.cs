#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace System
{
    [DefaultMember("Item")]
    [NativeMarshalling(typeof(ReadOnlySpanMarshaller<, >))]
    [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
    public ref readonly struct ReadOnlySpan<T>
    {
        public ReadOnlySpan(T[] array);
        public ReadOnlySpan(T[] array, int start, int length);
        [CLSCompliant(False)]
        public ReadOnlySpan(void* pointer, int length);
        public ReadOnlySpan(in T reference);

        public ref readonly T this[int index] { get; }
        public int Length { get; }
        public bool IsEmpty { get; }
        public static ReadOnlySpan<T> Empty { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use the equality operator instead.")]
        public override bool Equals(object obj);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
        public override int GetHashCode();
        public Enumerator GetEnumerator();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ref readonly T GetPinnableReference();
        public void CopyTo(Span<T> destination);
        public bool TryCopyTo(Span<T> destination);
        public override string ToString();
        public ReadOnlySpan<T> Slice(int start);
        public ReadOnlySpan<T> Slice(int start, int length);
        public T[] ToArray();

        public static bool operator !=(ReadOnlySpan<T> left, ReadOnlySpan<T> right);
        public static bool operator ==(ReadOnlySpan<T> left, ReadOnlySpan<T> right);

        public static implicit operator ReadOnlySpan<T>(T[] array);
        public static implicit operator ReadOnlySpan<T>(ArraySegment<T> segment);

        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct Enumerator
        {
            public ref readonly T Current { get; }

            public bool MoveNext();
        }
    }
}
