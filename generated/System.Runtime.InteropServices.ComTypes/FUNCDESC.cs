#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public struct FUNCDESC
    {

        public int memid;
        public nint lprgscode;
        public nint lprgelemdescParam;
        public FUNCKIND funckind;
        public INVOKEKIND invkind;
        public CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short oVft;
        public short cScodes;
        public ELEMDESC elemdescFunc;
        public short wFuncFlags;
    }
}
