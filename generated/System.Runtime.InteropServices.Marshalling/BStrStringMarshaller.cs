#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    [CustomMarshaller(typeof(string), MarshalMode.Default, typeof(BStrStringMarshaller))]
    [CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
    public static class BStrStringMarshaller
    {
        public static ushort* ConvertToUnmanaged(string managed);
        public static string ConvertToManaged(ushort* unmanaged);
        public static void Free(ushort* unmanaged);

        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct ManagedToUnmanagedIn
        {
            public static int BufferSize { get; }

            public void FromManaged(string managed, Span<byte> buffer);
            public ushort* ToUnmanaged();
            public void Free();
        }
    }
}
