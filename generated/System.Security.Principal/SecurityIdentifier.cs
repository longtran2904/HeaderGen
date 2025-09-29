#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

namespace System.Security.Principal
{
    public sealed class SecurityIdentifier : IdentityReference, IComparable<SecurityIdentifier>
    {

        public static readonly int MinBinaryLength;
        public static readonly int MaxBinaryLength;

        public SecurityIdentifier(string sddlForm);
        public SecurityIdentifier(byte[] binaryForm, int offset);
        public SecurityIdentifier(nint binaryForm);
        public SecurityIdentifier(WellKnownSidType sidType, SecurityIdentifier domainSid);

        public int BinaryLength { get; }
        public SecurityIdentifier AccountDomainSid { get; }
        public override string Value { get; }

        public override bool Equals(object o);
        public bool Equals(SecurityIdentifier sid);
        public override int GetHashCode();
        public override string ToString();
        public override bool IsValidTargetType(Type targetType);
        public bool IsAccountSid();
        public override IdentityReference Translate(Type targetType);
        public int CompareTo(SecurityIdentifier sid);
        public bool IsWellKnown(WellKnownSidType type);
        public void GetBinaryForm(byte[] binaryForm, int offset);
        public bool IsEqualDomainSid(SecurityIdentifier sid);

        public static bool operator ==(SecurityIdentifier left, SecurityIdentifier right);
        public static bool operator !=(SecurityIdentifier left, SecurityIdentifier right);
    }
}
