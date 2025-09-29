#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
    public sealed class PipeAccessRule : AccessRule
    {

        public PipeAccessRule(string identity, PipeAccessRights rights, AccessControlType type);
        public PipeAccessRule(IdentityReference identity, PipeAccessRights rights, AccessControlType type);

        public PipeAccessRights PipeAccessRights { get; }
    }
}
