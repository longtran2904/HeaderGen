#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public interface ICustomMarshaler
    {

        object MarshalNativeToManaged(nint pNativeData);
        nint MarshalManagedToNative(object ManagedObj);
        void CleanUpNativeData(nint pNativeData);
        void CleanUpManagedData(object ManagedObj);
        int GetNativeDataSize();
    }
}
