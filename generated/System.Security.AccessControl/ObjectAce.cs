#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Security.Principal;

namespace System.Security.AccessControl
{
    public sealed class ObjectAce : QualifiedAce
    {
        public ObjectAce(AceFlags aceFlags, AceQualifier qualifier, int accessMask, SecurityIdentifier sid, ObjectAceFlags flags, Guid type, Guid inheritedType, bool isCallback, byte[] opaque);

        public ObjectAceFlags ObjectAceFlags { get; set; }
        public Guid ObjectAceType { get; set; }
        public Guid InheritedObjectAceType { get; set; }
        public override int BinaryLength { get; }

        public static int MaxOpaqueLength(bool isCallback);
        public override void GetBinaryForm(byte[] binaryForm, int offset);
    }
}
