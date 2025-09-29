#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace Microsoft.Win32.SafeHandles
{
    public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeWaitHandle();
        public SafeWaitHandle(nint existingHandle, bool ownsHandle);

        protected override bool ReleaseHandle();
    }
}
