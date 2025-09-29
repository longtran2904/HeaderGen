#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    public abstract class ObjectSecurity
    {
        protected ObjectSecurity();
        protected ObjectSecurity(bool isContainer, bool isDS);
        protected ObjectSecurity(CommonSecurityDescriptor securityDescriptor);

        protected CommonSecurityDescriptor SecurityDescriptor { get; }
        protected bool OwnerModified { get; set; }
        protected bool GroupModified { get; set; }
        protected bool AuditRulesModified { get; set; }
        protected bool AccessRulesModified { get; set; }
        protected bool IsContainer { get; }
        protected bool IsDS { get; }
        public bool AreAccessRulesProtected { get; }
        public bool AreAuditRulesProtected { get; }
        public bool AreAccessRulesCanonical { get; }
        public bool AreAuditRulesCanonical { get; }
        public abstract Type AccessRightType { get; }
        public abstract Type AccessRuleType { get; }
        public abstract Type AuditRuleType { get; }

        protected void ReadLock();
        protected void ReadUnlock();
        protected void WriteLock();
        protected void WriteUnlock();
        protected virtual void Persist(string name, AccessControlSections includeSections);
        protected virtual void Persist(bool enableOwnershipPrivilege, string name, AccessControlSections includeSections);
        protected virtual void Persist(SafeHandle handle, AccessControlSections includeSections);
        public IdentityReference GetOwner(Type targetType);
        public void SetOwner(IdentityReference identity);
        public IdentityReference GetGroup(Type targetType);
        public void SetGroup(IdentityReference identity);
        public virtual void PurgeAccessRules(IdentityReference identity);
        public virtual void PurgeAuditRules(IdentityReference identity);
        public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance);
        public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance);
        public static bool IsSddlConversionSupported();
        public string GetSecurityDescriptorSddlForm(AccessControlSections includeSections);
        public void SetSecurityDescriptorSddlForm(string sddlForm);
        public void SetSecurityDescriptorSddlForm(string sddlForm, AccessControlSections includeSections);
        public byte[] GetSecurityDescriptorBinaryForm();
        public void SetSecurityDescriptorBinaryForm(byte[] binaryForm);
        public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, AccessControlSections includeSections);
        protected abstract bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified);
        protected abstract bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified);
        public virtual bool ModifyAccessRule(AccessControlModification modification, AccessRule rule, out bool modified);
        public virtual bool ModifyAuditRule(AccessControlModification modification, AuditRule rule, out bool modified);
        public abstract AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
        public abstract AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
    }
}
