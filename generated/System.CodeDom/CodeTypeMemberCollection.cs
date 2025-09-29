#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeTypeMemberCollection : CollectionBase
    {
        public CodeTypeMemberCollection();
        public CodeTypeMemberCollection(CodeTypeMemberCollection value);
        public CodeTypeMemberCollection(CodeTypeMember[] value);

        public CodeTypeMember this[int index] { get; set; }

        public int Add(CodeTypeMember value);
        public void AddRange(CodeTypeMember[] value);
        public void AddRange(CodeTypeMemberCollection value);
        public bool Contains(CodeTypeMember value);
        public void CopyTo(CodeTypeMember[] array, int index);
        public int IndexOf(CodeTypeMember value);
        public void Insert(int index, CodeTypeMember value);
        public void Remove(CodeTypeMember value);
    }
}
