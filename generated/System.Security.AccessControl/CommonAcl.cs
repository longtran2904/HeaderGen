#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Reflection;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    [DefaultMember("Item")]
    public abstract class CommonAcl : GenericAcl
    {

        public sealed override GenericAce this[int index] { get; set; }
        public sealed override byte Revision { get; }
        public sealed override int Count { get; }
        public sealed override int BinaryLength { get; }
        public bool IsCanonical { get; }
        public bool IsContainer { get; }
        public bool IsDS { get; }

        public sealed override void GetBinaryForm(byte[] binaryForm, int offset);
        public void RemoveInheritedAces();
        public void Purge(SecurityIdentifier sid);
    }
}
