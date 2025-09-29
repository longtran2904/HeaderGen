#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices.ComTypes
{
    [CLSCompliant(False)]
    public interface IDataObject
    {
        void GetData(in FORMATETC format, out STGMEDIUM medium);
        void GetDataHere(in FORMATETC format, ref STGMEDIUM medium);
        int QueryGetData(in FORMATETC format);
        int GetCanonicalFormatEtc(in FORMATETC formatIn, out FORMATETC formatOut);
        void SetData(in FORMATETC formatIn, in STGMEDIUM medium, bool release);
        IEnumFORMATETC EnumFormatEtc(DATADIR direction);
        int DAdvise(in FORMATETC pFormatetc, ADVF advf, IAdviseSink adviseSink, out int connection);
        void DUnadvise(int connection);
        int EnumDAdvise(out IEnumSTATDATA enumAdvise);
    }
}
