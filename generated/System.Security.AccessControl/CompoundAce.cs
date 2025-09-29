#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Security.Principal;

namespace System.Security.AccessControl
{
    public sealed class CompoundAce : KnownAce
    {

        public CompoundAce(AceFlags flags, int accessMask, CompoundAceType compoundAceType, SecurityIdentifier sid);

        public CompoundAceType CompoundAceType { get; set; }
        public override int BinaryLength { get; }

        public override void GetBinaryForm(byte[] binaryForm, int offset);
    }
}
