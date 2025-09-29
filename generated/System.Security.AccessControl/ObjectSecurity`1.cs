#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    public abstract class ObjectSecurity<T> : NativeObjectSecurity where T : struct
    {
        protected ObjectSecurity(bool isContainer, ResourceType resourceType);
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections);
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext);
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle safeHandle, AccessControlSections includeSections);
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle safeHandle, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext);

        public override Type AccessRightType { get; }
        public override Type AccessRuleType { get; }
        public override Type AuditRuleType { get; }

        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
        protected internal void Persist(SafeHandle handle);
        protected internal void Persist(string name);
        public virtual void AddAccessRule(AccessRule<T> rule);
        public virtual void SetAccessRule(AccessRule<T> rule);
        public virtual void ResetAccessRule(AccessRule<T> rule);
        public virtual bool RemoveAccessRule(AccessRule<T> rule);
        public virtual void RemoveAccessRuleAll(AccessRule<T> rule);
        public virtual void RemoveAccessRuleSpecific(AccessRule<T> rule);
        public virtual void AddAuditRule(AuditRule<T> rule);
        public virtual void SetAuditRule(AuditRule<T> rule);
        public virtual bool RemoveAuditRule(AuditRule<T> rule);
        public virtual void RemoveAuditRuleAll(AuditRule<T> rule);
        public virtual void RemoveAuditRuleSpecific(AuditRule<T> rule);
    }
}
