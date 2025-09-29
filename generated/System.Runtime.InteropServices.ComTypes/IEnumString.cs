#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IEnumString
    {

        int Next(int celt, out string[] rgelt, nint pceltFetched);
        int Skip(int celt);
        void Reset();
        void Clone(out IEnumString ppenum);
    }
}
