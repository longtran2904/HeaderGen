#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
    public enum PosixSignal
    {

        SIGHUP = -1,
        SIGINT = -2,
        SIGQUIT = -3,
        SIGTERM = -4,
        [UnsupportedOSPlatform("windows")]
        SIGCHLD = -5,
        [UnsupportedOSPlatform("windows")]
        SIGCONT = -6,
        [UnsupportedOSPlatform("windows")]
        SIGWINCH = -7,
        [UnsupportedOSPlatform("windows")]
        SIGTTIN = -8,
        [UnsupportedOSPlatform("windows")]
        SIGTTOU = -9,
        [UnsupportedOSPlatform("windows")]
        SIGTSTP = -10
    }
}
