#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.Security.AccessControl
{
    [DefaultMember("Item")]
    public abstract class GenericAcl : ICollection, IEnumerable
    {

        public static readonly byte AclRevision;
        public static readonly byte AclRevisionDS;
        public static readonly int MaxBinaryLength;

        protected GenericAcl();

        public abstract GenericAce this[int index] { get; set; }
        public abstract byte Revision { get; }
        public abstract int BinaryLength { get; }
        public abstract int Count { get; }
        public bool IsSynchronized { get; }
        public virtual object SyncRoot { get; }

        public abstract void GetBinaryForm(byte[] binaryForm, int offset);
        public void CopyTo(GenericAce[] array, int index);
        public AceEnumerator GetEnumerator();
    }
}
