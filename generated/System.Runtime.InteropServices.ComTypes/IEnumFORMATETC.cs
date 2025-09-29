#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IEnumFORMATETC
    {

        int Next(int celt, out FORMATETC[] rgelt, out int[] pceltFetched);
        int Skip(int celt);
        int Reset();
        void Clone(out IEnumFORMATETC newEnum);
    }
}
