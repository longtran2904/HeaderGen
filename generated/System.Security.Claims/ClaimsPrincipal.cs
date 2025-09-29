#region System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Claims.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Principal;

namespace System.Security.Claims
{
    public class ClaimsPrincipal : IPrincipal
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ClaimsPrincipal(SerializationInfo info, StreamingContext context);
        public ClaimsPrincipal();
        public ClaimsPrincipal(IEnumerable<ClaimsIdentity> identities);
        public ClaimsPrincipal(IIdentity identity);
        public ClaimsPrincipal(IPrincipal principal);
        public ClaimsPrincipal(BinaryReader reader);

        public static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> PrimaryIdentitySelector { get; set; }
        public static Func<ClaimsPrincipal> ClaimsPrincipalSelector { get; set; }
        public virtual IEnumerable<Claim> Claims { get; }
        protected virtual byte[] CustomSerializationData { get; }
        public static ClaimsPrincipal Current { get; }
        public virtual IEnumerable<ClaimsIdentity> Identities { get; }
        public virtual IIdentity Identity { get; }

        public virtual void AddIdentity(ClaimsIdentity identity);
        public virtual void AddIdentities(IEnumerable<ClaimsIdentity> identities);
        public virtual ClaimsPrincipal Clone();
        protected virtual ClaimsIdentity CreateClaimsIdentity(BinaryReader reader);
        public virtual IEnumerable<Claim> FindAll(Predicate<Claim> match);
        public virtual IEnumerable<Claim> FindAll(string type);
        public virtual Claim FindFirst(Predicate<Claim> match);
        public virtual Claim FindFirst(string type);
        public virtual bool HasClaim(Predicate<Claim> match);
        public virtual bool HasClaim(string type, string value);
        public virtual bool IsInRole(string role);
        public virtual void WriteTo(BinaryWriter writer);
        protected virtual void WriteTo(BinaryWriter writer, byte[] userData);
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
