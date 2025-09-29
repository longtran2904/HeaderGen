#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

namespace System.Security.AccessControl
{
    public abstract class CommonObjectSecurity : ObjectSecurity
    {

        protected CommonObjectSecurity(bool isContainer);

        protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified);
        protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified);
        protected void AddAccessRule(AccessRule rule);
        protected void SetAccessRule(AccessRule rule);
        protected void ResetAccessRule(AccessRule rule);
        protected bool RemoveAccessRule(AccessRule rule);
        protected void RemoveAccessRuleAll(AccessRule rule);
        protected void RemoveAccessRuleSpecific(AccessRule rule);
        protected void AddAuditRule(AuditRule rule);
        protected void SetAuditRule(AuditRule rule);
        protected bool RemoveAuditRule(AuditRule rule);
        protected void RemoveAuditRuleAll(AuditRule rule);
        protected void RemoveAuditRuleSpecific(AuditRule rule);
        public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType);
        public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType);
    }
}
