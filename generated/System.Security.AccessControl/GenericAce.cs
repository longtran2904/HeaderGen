#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

namespace System.Security.AccessControl
{
    public abstract class GenericAce
    {

        public AceType AceType { get; }
        public AceFlags AceFlags { get; set; }
        public bool IsInherited { get; }
        public InheritanceFlags InheritanceFlags { get; }
        public PropagationFlags PropagationFlags { get; }
        public AuditFlags AuditFlags { get; }
        public abstract int BinaryLength { get; }

        public static GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset);
        public abstract void GetBinaryForm(byte[] binaryForm, int offset);
        public GenericAce Copy();
        public sealed override bool Equals(object o);
        public sealed override int GetHashCode();

        public static bool operator ==(GenericAce left, GenericAce right);
        public static bool operator !=(GenericAce left, GenericAce right);
    }
}
