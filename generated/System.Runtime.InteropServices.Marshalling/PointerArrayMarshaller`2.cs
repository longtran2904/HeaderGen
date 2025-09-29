#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    [ContiguousCollectionMarshaller]
    [CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder*[]), MarshalMode.Default, typeof(PointerArrayMarshaller<, >))]
    [CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder*[]), MarshalMode.ManagedToUnmanagedIn, typeof(PointerArrayMarshaller<, >.ManagedToUnmanagedIn))]
    public static class PointerArrayMarshaller<T, TUnmanagedElement> where T : unmanaged where TUnmanagedElement : unmanaged
    {
        public static TUnmanagedElement* AllocateContainerForUnmanagedElements(T*[] managed, out int numElements);
        public static ReadOnlySpan<nint> GetManagedValuesSource(T*[] managed);
        public static Span<TUnmanagedElement> GetUnmanagedValuesDestination(TUnmanagedElement* unmanaged, int numElements);
        public static T*[] AllocateContainerForManagedElements(TUnmanagedElement* unmanaged, int numElements);
        public static Span<nint> GetManagedValuesDestination(T*[] managed);
        public static ReadOnlySpan<TUnmanagedElement> GetUnmanagedValuesSource(TUnmanagedElement* unmanagedValue, int numElements);
        public static void Free(TUnmanagedElement* unmanaged);

        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct ManagedToUnmanagedIn
        {
            public static int BufferSize { get; }

            public void FromManaged(T*[] array, Span<TUnmanagedElement> buffer);
            public ReadOnlySpan<nint> GetManagedValuesSource();
            public Span<TUnmanagedElement> GetUnmanagedValuesDestination();
            public ref TUnmanagedElement GetPinnableReference();
            public TUnmanagedElement* ToUnmanaged();
            public void Free();
            public static ref byte GetPinnableReference(T*[] array);
        }
    }
}
