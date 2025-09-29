#region System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Claims.dll
#endregion

using System.Security.Claims;

namespace System.Security.Principal
{
    public class GenericPrincipal : ClaimsPrincipal
    {

        public GenericPrincipal(IIdentity identity, string[] roles);

        public override IIdentity Identity { get; }

        public override bool IsInRole(string role);
    }
}
