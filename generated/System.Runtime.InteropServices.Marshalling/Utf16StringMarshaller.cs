#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    [CustomMarshaller(typeof(string), MarshalMode.Default, typeof(Utf16StringMarshaller))]
    public static class Utf16StringMarshaller
    {

        public static ushort* ConvertToUnmanaged(string managed);
        public static string ConvertToManaged(ushort* unmanaged);
        public static void Free(ushort* unmanaged);
        public static ref readonly char GetPinnableReference(string str);
    }
}
