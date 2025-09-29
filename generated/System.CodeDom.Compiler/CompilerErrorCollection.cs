#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom.Compiler
{
    [DefaultMember("Item")]
    public class CompilerErrorCollection : CollectionBase
    {

        public CompilerErrorCollection();
        public CompilerErrorCollection(CompilerErrorCollection value);
        public CompilerErrorCollection(CompilerError[] value);

        public CompilerError this[int index] { get; set; }
        public bool HasErrors { get; }
        public bool HasWarnings { get; }

        public int Add(CompilerError value);
        public void AddRange(CompilerError[] value);
        public void AddRange(CompilerErrorCollection value);
        public bool Contains(CompilerError value);
        public void CopyTo(CompilerError[] array, int index);
        public int IndexOf(CompilerError value);
        public void Insert(int index, CompilerError value);
        public void Remove(CompilerError value);
    }
}
