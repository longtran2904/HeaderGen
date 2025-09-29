#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Security.Principal;

namespace System.Security.AccessControl
{
    public sealed class RawSecurityDescriptor : GenericSecurityDescriptor
    {

        public RawSecurityDescriptor(ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, RawAcl systemAcl, RawAcl discretionaryAcl);
        public RawSecurityDescriptor(string sddlForm);
        public RawSecurityDescriptor(byte[] binaryForm, int offset);

        public override ControlFlags ControlFlags { get; }
        public override SecurityIdentifier Owner { get; set; }
        public override SecurityIdentifier Group { get; set; }
        public RawAcl SystemAcl { get; set; }
        public RawAcl DiscretionaryAcl { get; set; }
        public byte ResourceManagerControl { get; set; }

        public void SetFlags(ControlFlags flags);
    }
}
