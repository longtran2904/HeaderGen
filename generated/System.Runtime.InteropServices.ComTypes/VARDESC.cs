#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public struct VARDESC
    {
        public int memid;
        public string lpstrSchema;
        public DESCUNION desc;
        public ELEMDESC elemdescVar;
        public short wVarFlags;
        public VARKIND varkind;

        public struct DESCUNION
        {
            public int oInst;
            public nint lpvarValue;
        }
    }
}
