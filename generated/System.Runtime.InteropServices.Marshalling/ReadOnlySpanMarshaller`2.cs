#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    [ContiguousCollectionMarshaller]
    [CustomMarshaller(typeof(ReadOnlySpan<>), MarshalMode.ManagedToUnmanagedIn, typeof(ReadOnlySpanMarshaller<, >.ManagedToUnmanagedIn))]
    [CustomMarshaller(typeof(ReadOnlySpan<>), MarshalMode.UnmanagedToManagedOut, typeof(ReadOnlySpanMarshaller<, >.UnmanagedToManagedOut))]
    public static class ReadOnlySpanMarshaller<T, TUnmanagedElement> where TUnmanagedElement : unmanaged
    {
        public static class UnmanagedToManagedOut
        {
            public static TUnmanagedElement* AllocateContainerForUnmanagedElements(ReadOnlySpan<T> managed, out int numElements);
            public static ReadOnlySpan<T> GetManagedValuesSource(ReadOnlySpan<T> managed);
            public static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements);
        }
        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct ManagedToUnmanagedIn
        {
            public static int BufferSize { get; }

            public void FromManaged(ReadOnlySpan<T> managed, Span<TUnmanagedElement> buffer);
            public ReadOnlySpan<T> GetManagedValuesSource();
            public Span<TUnmanagedElement> GetUnmanagedValuesDestination();
            public ref TUnmanagedElement GetPinnableReference();
            public TUnmanagedElement* ToUnmanaged();
            public void Free();
            public static ref T GetPinnableReference(ReadOnlySpan<T> managed);
        }
    }
}
