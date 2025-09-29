#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

using System.Collections.Generic;
using System.Security.Claims;

namespace System.Security.Principal
{
    public class WindowsPrincipal : ClaimsPrincipal
    {
        public WindowsPrincipal(WindowsIdentity ntIdentity);

        public override IIdentity Identity { get; }
        public virtual IEnumerable<Claim> UserClaims { get; }
        public virtual IEnumerable<Claim> DeviceClaims { get; }

        public override bool IsInRole(string role);
        public virtual bool IsInRole(WindowsBuiltInRole role);
        public virtual bool IsInRole(int rid);
        public virtual bool IsInRole(SecurityIdentifier sid);
    }
}
