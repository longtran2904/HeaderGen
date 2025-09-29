#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeTypeParameterCollection : CollectionBase
    {
        public CodeTypeParameterCollection();
        public CodeTypeParameterCollection(CodeTypeParameterCollection value);
        public CodeTypeParameterCollection(CodeTypeParameter[] value);

        public CodeTypeParameter this[int index] { get; set; }

        public int Add(CodeTypeParameter value);
        public void Add(string value);
        public void AddRange(CodeTypeParameter[] value);
        public void AddRange(CodeTypeParameterCollection value);
        public bool Contains(CodeTypeParameter value);
        public void CopyTo(CodeTypeParameter[] array, int index);
        public int IndexOf(CodeTypeParameter value);
        public void Insert(int index, CodeTypeParameter value);
        public void Remove(CodeTypeParameter value);
    }
}
