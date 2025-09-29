#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IBindCtx
    {

        void RegisterObjectBound(object punk);
        void RevokeObjectBound(object punk);
        void ReleaseBoundObjects();
        void SetBindOptions(in BIND_OPTS pbindopts);
        void GetBindOptions(ref BIND_OPTS pbindopts);
        void GetRunningObjectTable(out IRunningObjectTable pprot);
        void RegisterObjectParam(string pszKey, object punk);
        void GetObjectParam(string pszKey, out object ppunk);
        void EnumObjectParam(out IEnumString ppenum);
        int RevokeObjectParam(string pszKey);
    }
}
