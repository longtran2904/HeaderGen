#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Flags]
    public enum IDLFLAG
    {
        IDLFLAG_NONE = 0,
        IDLFLAG_FIN = 1,
        IDLFLAG_FOUT = 2,
        IDLFLAG_FLCID = 4,
        IDLFLAG_FRETVAL = 8
    }
}
