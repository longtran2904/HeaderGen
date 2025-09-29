#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeNamespace : CodeObject
    {
        public CodeNamespace();
        public CodeNamespace(string name);

        public CodeTypeDeclarationCollection Types { get; }
        public CodeNamespaceImportCollection Imports { get; }
        public string Name { get; set; }
        public CodeCommentStatementCollection Comments { get; }

        public event EventHandler PopulateComments;
        public event EventHandler PopulateImports;
        public event EventHandler PopulateTypes;
    }
}
