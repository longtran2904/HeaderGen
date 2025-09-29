#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IStream
    {

        void Read(out byte[] pv, int cb, nint pcbRead);
        void Write(byte[] pv, int cb, nint pcbWritten);
        void Seek(long dlibMove, int dwOrigin, nint plibNewPosition);
        void SetSize(long libNewSize);
        void CopyTo(IStream pstm, long cb, nint pcbRead, nint pcbWritten);
        void Commit(int grfCommitFlags);
        void Revert();
        void LockRegion(long libOffset, long cb, int dwLockType);
        void UnlockRegion(long libOffset, long cb, int dwLockType);
        void Stat(out STATSTG pstatstg, int grfStatFlag);
        void Clone(out IStream ppstm);
    }
}
