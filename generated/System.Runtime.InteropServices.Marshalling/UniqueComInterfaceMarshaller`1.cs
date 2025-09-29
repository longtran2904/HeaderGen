#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.Runtime.Versioning;

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    [CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.Default, typeof(UniqueComInterfaceMarshaller<>))]
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static class UniqueComInterfaceMarshaller<T>
    {
        public static void* ConvertToUnmanaged(T managed);
        public static T ConvertToManaged(void* unmanaged);
        public static void Free(void* unmanaged);
    }
}
