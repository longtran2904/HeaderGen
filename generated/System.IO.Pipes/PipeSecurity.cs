#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
    public class PipeSecurity : NativeObjectSecurity
    {
        public PipeSecurity();

        public override Type AccessRightType { get; }
        public override Type AccessRuleType { get; }
        public override Type AuditRuleType { get; }

        public void AddAccessRule(PipeAccessRule rule);
        public void SetAccessRule(PipeAccessRule rule);
        public void ResetAccessRule(PipeAccessRule rule);
        public bool RemoveAccessRule(PipeAccessRule rule);
        public void RemoveAccessRuleSpecific(PipeAccessRule rule);
        public void AddAuditRule(PipeAuditRule rule);
        public void SetAuditRule(PipeAuditRule rule);
        public bool RemoveAuditRule(PipeAuditRule rule);
        public void RemoveAuditRuleAll(PipeAuditRule rule);
        public void RemoveAuditRuleSpecific(PipeAuditRule rule);
        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
        public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
        protected internal void Persist(SafeHandle handle);
        protected internal void Persist(string name);
    }
}
