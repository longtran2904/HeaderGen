#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Security
{
    public static class SecureStringMarshal
    {
        public static nint SecureStringToCoTaskMemAnsi(SecureString s);
        public static nint SecureStringToGlobalAllocAnsi(SecureString s);
        public static nint SecureStringToCoTaskMemUnicode(SecureString s);
        public static nint SecureStringToGlobalAllocUnicode(SecureString s);
    }
}
