#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeAttributeArgumentCollection : CollectionBase
    {

        public CodeAttributeArgumentCollection();
        public CodeAttributeArgumentCollection(CodeAttributeArgumentCollection value);
        public CodeAttributeArgumentCollection(CodeAttributeArgument[] value);

        public CodeAttributeArgument this[int index] { get; set; }

        public int Add(CodeAttributeArgument value);
        public void AddRange(CodeAttributeArgument[] value);
        public void AddRange(CodeAttributeArgumentCollection value);
        public bool Contains(CodeAttributeArgument value);
        public void CopyTo(CodeAttributeArgument[] array, int index);
        public int IndexOf(CodeAttributeArgument value);
        public void Insert(int index, CodeAttributeArgument value);
        public void Remove(CodeAttributeArgument value);
    }
}
