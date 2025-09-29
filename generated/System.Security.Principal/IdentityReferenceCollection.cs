#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System.Security.Principal
{
    [DefaultMember("Item")]
    public class IdentityReferenceCollection : ICollection<IdentityReference>, IEnumerable, IEnumerable<IdentityReference>
    {

        public IdentityReferenceCollection();
        public IdentityReferenceCollection(int capacity);

        public IdentityReference this[int index] { get; set; }
        public int Count { get; }

        public void CopyTo(IdentityReference[] array, int offset);
        public void Add(IdentityReference identity);
        public bool Remove(IdentityReference identity);
        public void Clear();
        public bool Contains(IdentityReference identity);
        public IEnumerator<IdentityReference> GetEnumerator();
        public IdentityReferenceCollection Translate(Type targetType);
        public IdentityReferenceCollection Translate(Type targetType, bool forceSuccess);
    }
}
