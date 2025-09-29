#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public struct EXCEPINFO
    {
        public short wCode;
        public short wReserved;
        public string bstrSource;
        public string bstrDescription;
        public string bstrHelpFile;
        public int dwHelpContext;
        public nint pvReserved;
        public nint pfnDeferredFillIn;
        public int scode;
    }
}
