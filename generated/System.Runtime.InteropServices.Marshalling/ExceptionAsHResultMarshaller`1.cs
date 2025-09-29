#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.Numerics;

namespace System.Runtime.InteropServices.Marshalling
{
    [CustomMarshaller(typeof(Exception), MarshalMode.UnmanagedToManagedOut, typeof(ExceptionAsHResultMarshaller<>))]
    public static class ExceptionAsHResultMarshaller<T> where T : INumber<T>, unmanaged
    {
        public static T ConvertToUnmanaged(Exception e);
    }
}
