#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Security.Principal;

namespace System.Security.AccessControl
{
    public abstract class AuditRule : AuthorizationRule
    {

        protected AuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags);

        public AuditFlags AuditFlags { get; }
    }
}
