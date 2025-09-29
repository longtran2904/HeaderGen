#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices
{
    public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
    {
        protected nint handle;

        protected SafeHandle(nint invalidHandleValue, bool ownsHandle);

        ~SafeHandle();

        public bool IsClosed { get; }
        public abstract bool IsInvalid { get; }

        protected internal void SetHandle(nint handle);
        public nint DangerousGetHandle();
        public void Close();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public void SetHandleAsInvalid();
        protected abstract bool ReleaseHandle();
        public void DangerousAddRef(ref bool success);
        public void DangerousRelease();
    }
}
