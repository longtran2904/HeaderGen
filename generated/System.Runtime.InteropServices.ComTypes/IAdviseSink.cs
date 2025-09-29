#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IAdviseSink
    {

        void OnDataChange(in FORMATETC format, in STGMEDIUM stgmedium);
        void OnViewChange(int aspect, int index);
        void OnRename(IMoniker moniker);
        void OnSave();
        void OnClose();
    }
}
