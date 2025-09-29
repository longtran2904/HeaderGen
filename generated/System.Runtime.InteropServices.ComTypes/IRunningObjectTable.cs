#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IRunningObjectTable
    {

        int Register(int grfFlags, object punkObject, IMoniker pmkObjectName);
        void Revoke(int dwRegister);
        int IsRunning(IMoniker pmkObjectName);
        int GetObject(IMoniker pmkObjectName, out object ppunkObject);
        void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);
        int GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);
        void EnumRunning(out IEnumMoniker ppenumMoniker);
    }
}
