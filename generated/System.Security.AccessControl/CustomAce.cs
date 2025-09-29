#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

namespace System.Security.AccessControl
{
    public sealed class CustomAce : GenericAce
    {
        public static readonly int MaxOpaqueLength;

        public CustomAce(AceType type, AceFlags flags, byte[] opaque);

        public int OpaqueLength { get; }
        public override int BinaryLength { get; }

        public byte[] GetOpaque();
        public void SetOpaque(byte[] opaque);
        public override void GetBinaryForm(byte[] binaryForm, int offset);
    }
}
