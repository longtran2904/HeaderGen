#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    [ContiguousCollectionMarshaller]
    [CustomMarshaller(typeof(Span<>), MarshalMode.Default, typeof(SpanMarshaller<, >))]
    [CustomMarshaller(typeof(Span<>), MarshalMode.ManagedToUnmanagedIn, typeof(SpanMarshaller<, >.ManagedToUnmanagedIn))]
    public static class SpanMarshaller<T, TUnmanagedElement> where TUnmanagedElement : unmanaged
    {

        public static TUnmanagedElement* AllocateContainerForUnmanagedElements(Span<T> managed, out int numElements);
        public static ReadOnlySpan<T> GetManagedValuesSource(Span<T> managed);
        public static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements);
        public static Span<T> AllocateContainerForManagedElements(TUnmanagedElement* unmanaged, int numElements);
        public static Span<T> GetManagedValuesDestination(Span<T> managed);
        public static ReadOnlySpan<TUnmanagedElement> GetUnmanagedValuesSource(TUnmanagedElement* unmanaged, int numElements);
        public static void Free(TUnmanagedElement* unmanaged);
        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct ManagedToUnmanagedIn
        {

            public static int BufferSize { get; }

            public void FromManaged(Span<T> managed, Span<TUnmanagedElement> buffer);
            public ReadOnlySpan<T> GetManagedValuesSource();
            public Span<TUnmanagedElement> GetUnmanagedValuesDestination();
            public ref TUnmanagedElement GetPinnableReference();
            public TUnmanagedElement* ToUnmanaged();
            public void Free();
            public static ref T GetPinnableReference(Span<T> managed);
        }
    }
}
