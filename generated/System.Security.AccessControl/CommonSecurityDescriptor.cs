#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Security.Principal;

namespace System.Security.AccessControl
{
    public sealed class CommonSecurityDescriptor : GenericSecurityDescriptor
    {
        public CommonSecurityDescriptor(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl);
        public CommonSecurityDescriptor(bool isContainer, bool isDS, RawSecurityDescriptor rawSecurityDescriptor);
        public CommonSecurityDescriptor(bool isContainer, bool isDS, string sddlForm);
        public CommonSecurityDescriptor(bool isContainer, bool isDS, byte[] binaryForm, int offset);

        public bool IsContainer { get; }
        public bool IsDS { get; }
        public override ControlFlags ControlFlags { get; }
        public override SecurityIdentifier Owner { get; set; }
        public override SecurityIdentifier Group { get; set; }
        public SystemAcl SystemAcl { get; set; }
        public DiscretionaryAcl DiscretionaryAcl { get; set; }
        public bool IsSystemAclCanonical { get; }
        public bool IsDiscretionaryAclCanonical { get; }

        public void SetSystemAclProtection(bool isProtected, bool preserveInheritance);
        public void SetDiscretionaryAclProtection(bool isProtected, bool preserveInheritance);
        public void PurgeAccessControl(SecurityIdentifier sid);
        public void PurgeAudit(SecurityIdentifier sid);
        public void AddDiscretionaryAcl(byte revision, int trusted);
        public void AddSystemAcl(byte revision, int trusted);
    }
}
