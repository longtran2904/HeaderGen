#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices
{
    public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable
    {
        protected nint handle;

        protected CriticalHandle(nint invalidHandleValue);

        ~CriticalHandle();

        public bool IsClosed { get; }
        public abstract bool IsInvalid { get; }

        protected void SetHandle(nint handle);
        public void Close();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public void SetHandleAsInvalid();
        protected abstract bool ReleaseHandle();
    }
}
