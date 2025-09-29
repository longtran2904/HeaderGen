#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

namespace Microsoft.Win32.SafeHandles
{
    public sealed class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {

        public SafePipeHandle();
        public SafePipeHandle(nint preexistingHandle, bool ownsHandle);

        protected override bool ReleaseHandle();
    }
}
