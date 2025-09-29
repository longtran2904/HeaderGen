#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

namespace System.Threading
{
    public class HostExecutionContext : IDisposable
    {
        public HostExecutionContext();
        public HostExecutionContext(object state);

        protected internal object State { get; set; }

        public virtual HostExecutionContext CreateCopy();
        public void Dispose();
        public virtual void Dispose(bool disposing);
    }
}
