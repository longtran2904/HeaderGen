#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace System
{
    [DefaultMember("Item")]
    [NativeMarshalling(typeof(SpanMarshaller<, >))]
    [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
    public ref readonly struct Span<T>
    {
        public Span(T[] array);
        public Span(T[] array, int start, int length);
        [CLSCompliant(False)]
        public Span(void* pointer, int length);
        public Span(ref T reference);

        public ref T this[int index] { get; }
        public int Length { get; }
        public bool IsEmpty { get; }
        public static Span<T> Empty { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Equals() on Span will always throw an exception. Use the equality operator instead.")]
        public override bool Equals(object obj);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GetHashCode() on Span will always throw an exception.")]
        public override int GetHashCode();
        public Enumerator GetEnumerator();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ref T GetPinnableReference();
        public void Clear();
        public void Fill(T value);
        public void CopyTo(Span<T> destination);
        public bool TryCopyTo(Span<T> destination);
        public override string ToString();
        public Span<T> Slice(int start);
        public Span<T> Slice(int start, int length);
        public T[] ToArray();

        public static bool operator !=(Span<T> left, Span<T> right);
        public static bool operator ==(Span<T> left, Span<T> right);

        public static implicit operator Span<T>(T[] array);
        public static implicit operator Span<T>(ArraySegment<T> segment);
        public static implicit operator ReadOnlySpan<T>(Span<T> span);

        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct Enumerator
        {
            public ref T Current { get; }

            public bool MoveNext();
        }
    }
}
