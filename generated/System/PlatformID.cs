#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System
{
    public enum PlatformID
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        Win32S = 0,
        [EditorBrowsable(EditorBrowsableState.Never)]
        Win32Windows = 1,
        Win32NT = 2,
        [EditorBrowsable(EditorBrowsableState.Never)]
        WinCE = 3,
        Unix = 4,
        [EditorBrowsable(EditorBrowsableState.Never)]
        Xbox = 5,
        [EditorBrowsable(EditorBrowsableState.Never)]
        MacOSX = 6,
        Other = 7
    }
}
