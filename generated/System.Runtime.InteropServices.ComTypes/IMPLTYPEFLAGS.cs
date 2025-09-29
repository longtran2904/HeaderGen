#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Flags]
    public enum IMPLTYPEFLAGS
    {

        IMPLTYPEFLAG_FDEFAULT = 1,
        IMPLTYPEFLAG_FSOURCE = 2,
        IMPLTYPEFLAG_FRESTRICTED = 4,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8
    }
}
