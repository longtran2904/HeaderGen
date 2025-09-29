#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
    public sealed class SafeAccessTokenHandle : SafeHandle
    {

        public SafeAccessTokenHandle();
        public SafeAccessTokenHandle(nint handle);

        public static SafeAccessTokenHandle InvalidHandle { get; }
        public override bool IsInvalid { get; }

        protected override bool ReleaseHandle();
    }
}
