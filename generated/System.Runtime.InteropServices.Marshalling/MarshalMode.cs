#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    public enum MarshalMode
    {
        Default = 0,
        ManagedToUnmanagedIn = 1,
        ManagedToUnmanagedRef = 2,
        ManagedToUnmanagedOut = 3,
        UnmanagedToManagedIn = 4,
        UnmanagedToManagedRef = 5,
        UnmanagedToManagedOut = 6,
        ElementIn = 7,
        ElementRef = 8,
        ElementOut = 9
    }
}
