#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface ITypeInfo
    {
        void GetTypeAttr(out nint ppTypeAttr);
        void GetTypeComp(out ITypeComp ppTComp);
        void GetFuncDesc(int index, out nint ppFuncDesc);
        void GetVarDesc(int index, out nint ppVarDesc);
        void GetNames(int memid, out string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetRefTypeOfImplType(int index, out int href);
        void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);
        void GetIDsOfNames(in string[] rgszNames, int cNames, out int[] pMemId);
        void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, out int puArgErr);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetDllEntry(int memid, INVOKEKIND invKind, nint pBstrDllName, nint pBstrName, nint pwOrdinal);
        void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);
        void AddressOfMember(int memid, INVOKEKIND invKind, out nint ppv);
        void CreateInstance(object pUnkOuter, in Guid riid, out object ppvObj);
        void GetMops(int memid, out string pBstrMops);
        void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);
        void ReleaseTypeAttr(nint pTypeAttr);
        void ReleaseFuncDesc(nint pFuncDesc);
        void ReleaseVarDesc(nint pVarDesc);
    }
}
