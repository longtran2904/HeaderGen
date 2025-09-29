#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

namespace System.Threading
{
    public class HostExecutionContextManager
    {
        public HostExecutionContextManager();

        public virtual HostExecutionContext Capture();
        public virtual object SetHostExecutionContext(HostExecutionContext hostExecutionContext);
        public virtual void Revert(object previousState);
    }
}
