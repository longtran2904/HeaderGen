#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Flags]
    public enum PARAMFLAG
    {
        PARAMFLAG_NONE = 0,
        PARAMFLAG_FIN = 1,
        PARAMFLAG_FOUT = 2,
        PARAMFLAG_FLCID = 4,
        PARAMFLAG_FRETVAL = 8,
        PARAMFLAG_FOPT = 16,
        PARAMFLAG_FHASDEFAULT = 32,
        PARAMFLAG_FHASCUSTDATA = 64
    }
}
