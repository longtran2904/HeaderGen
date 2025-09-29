#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
    public sealed class PosixSignalRegistration : IDisposable
    {

        ~PosixSignalRegistration();

        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static PosixSignalRegistration Create(PosixSignal signal, Action<PosixSignalContext> handler);
        public void Dispose();
    }
}
