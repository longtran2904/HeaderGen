#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.ManagedToUnmanagedIn, typeof(SafeHandleMarshaller<>.ManagedToUnmanagedIn))]
    [CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.ManagedToUnmanagedRef, typeof(SafeHandleMarshaller<>.ManagedToUnmanagedRef))]
    [CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.ManagedToUnmanagedOut, typeof(SafeHandleMarshaller<>.ManagedToUnmanagedOut))]
    public static class SafeHandleMarshaller<T> where T : SafeHandle
    {
        public struct ManagedToUnmanagedIn
        {

            public void FromManaged(T handle);
            public nint ToUnmanaged();
            public void Free();
        }
        public struct ManagedToUnmanagedRef
        {

            public ManagedToUnmanagedRef();

            public void FromManaged(T handle);
            public nint ToUnmanaged();
            public void FromUnmanaged(nint value);
            public void OnInvoked();
            public T ToManagedFinally();
            public void Free();
        }
        public struct ManagedToUnmanagedOut
        {

            public ManagedToUnmanagedOut();

            public void FromUnmanaged(nint value);
            public T ToManaged();
            public void Free();
        }
    }
}
