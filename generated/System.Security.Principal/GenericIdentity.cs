#region System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Claims.dll
#endregion

using System.Collections.Generic;
using System.Security.Claims;

namespace System.Security.Principal
{
    public class GenericIdentity : ClaimsIdentity
    {
        public GenericIdentity(string name);
        public GenericIdentity(string name, string type);
        protected GenericIdentity(GenericIdentity identity);

        public override IEnumerable<Claim> Claims { get; }
        public override string Name { get; }
        public override string AuthenticationType { get; }
        public override bool IsAuthenticated { get; }

        public override ClaimsIdentity Clone();
    }
}
