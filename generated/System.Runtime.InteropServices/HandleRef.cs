#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public readonly struct HandleRef
    {

        public HandleRef(object wrapper, nint handle);

        public object Wrapper { get; }
        public nint Handle { get; }

        public static nint ToIntPtr(HandleRef value);

        public static explicit operator nint(HandleRef value);
    }
}
