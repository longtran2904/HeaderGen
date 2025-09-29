#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace Microsoft.Win32.SafeHandles
{
    public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {

        public SafeFileHandle(nint preexistingHandle, bool ownsHandle);
        public SafeFileHandle();

        public bool IsAsync { get; }

        protected override bool ReleaseHandle();
    }
}
