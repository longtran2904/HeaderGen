#region System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Claims.dll
#endregion

using System.Collections.Generic;
using System.IO;

namespace System.Security.Claims
{
    public class Claim
    {

        public Claim(BinaryReader reader);
        public Claim(BinaryReader reader, ClaimsIdentity subject);
        public Claim(string type, string value);
        public Claim(string type, string value, string valueType);
        public Claim(string type, string value, string valueType, string issuer);
        public Claim(string type, string value, string valueType, string issuer, string originalIssuer);
        public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject);
        protected Claim(Claim other);
        protected Claim(Claim other, ClaimsIdentity subject);

        protected virtual byte[] CustomSerializationData { get; }
        public string Issuer { get; }
        public string OriginalIssuer { get; }
        public IDictionary<string, string> Properties { get; }
        public ClaimsIdentity Subject { get; }
        public string Type { get; }
        public string Value { get; }
        public string ValueType { get; }

        public virtual Claim Clone();
        public virtual Claim Clone(ClaimsIdentity identity);
        public virtual void WriteTo(BinaryWriter writer);
        protected virtual void WriteTo(BinaryWriter writer, byte[] userData);
        public override string ToString();
    }
}
