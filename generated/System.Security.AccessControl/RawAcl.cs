#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Reflection;

namespace System.Security.AccessControl
{
    [DefaultMember("Item")]
    public sealed class RawAcl : GenericAcl
    {

        public RawAcl(byte revision, int capacity);
        public RawAcl(byte[] binaryForm, int offset);

        public override GenericAce this[int index] { get; set; }
        public override byte Revision { get; }
        public override int Count { get; }
        public override int BinaryLength { get; }

        public override void GetBinaryForm(byte[] binaryForm, int offset);
        public void InsertAce(int index, GenericAce ace);
        public void RemoveAce(int index);
    }
}
