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
    public class ClaimsIdentity : IIdentity
    {
        public const string DefaultIssuer = "LOCAL AUTHORITY";
        public const string DefaultNameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
        public const string DefaultRoleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

        public ClaimsIdentity();
        public ClaimsIdentity(IIdentity identity);
        public ClaimsIdentity(IEnumerable<Claim> claims);
        public ClaimsIdentity(string authenticationType);
        public ClaimsIdentity(IEnumerable<Claim> claims, string authenticationType);
        public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims);
        public ClaimsIdentity(string authenticationType, string nameType, string roleType);
        public ClaimsIdentity(IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType);
        public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType);
        public ClaimsIdentity(BinaryReader reader);
        protected ClaimsIdentity(ClaimsIdentity other);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ClaimsIdentity(SerializationInfo info, StreamingContext context);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ClaimsIdentity(SerializationInfo info);

        public virtual string AuthenticationType { get; }
        public virtual bool IsAuthenticated { get; }
        public ClaimsIdentity Actor { get; set; }
        public object BootstrapContext { get; set; }
        public virtual IEnumerable<Claim> Claims { get; }
        protected virtual byte[] CustomSerializationData { get; }
        public string Label { get; set; }
        public virtual string Name { get; }
        public string NameClaimType { get; }
        public string RoleClaimType { get; }

        public virtual ClaimsIdentity Clone();
        public virtual void AddClaim(Claim claim);
        public virtual void AddClaims(IEnumerable<Claim> claims);
        public virtual bool TryRemoveClaim(Claim claim);
        public virtual void RemoveClaim(Claim claim);
        public virtual IEnumerable<Claim> FindAll(Predicate<Claim> match);
        public virtual IEnumerable<Claim> FindAll(string type);
        public virtual Claim FindFirst(Predicate<Claim> match);
        public virtual Claim FindFirst(string type);
        public virtual bool HasClaim(Predicate<Claim> match);
        public virtual bool HasClaim(string type, string value);
        protected virtual Claim CreateClaim(BinaryReader reader);
        public virtual void WriteTo(BinaryWriter writer);
        protected virtual void WriteTo(BinaryWriter writer, byte[] userData);
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
