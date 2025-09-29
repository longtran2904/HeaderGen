#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public struct TYPEATTR
    {
        public Guid guid;
        public int lcid;
        public int dwReserved;
        public int memidConstructor;
        public int memidDestructor;
        public nint lpstrSchema;
        public int cbSizeInstance;
        public TYPEKIND typekind;
        public short cFuncs;
        public short cVars;
        public short cImplTypes;
        public short cbSizeVft;
        public short cbAlignment;
        public TYPEFLAGS wTypeFlags;
        public short wMajorVerNum;
        public short wMinorVerNum;
        public TYPEDESC tdescAlias;
        public IDLDESC idldescType;
        public const int MEMBER_ID_NIL = -1;
    }
}
