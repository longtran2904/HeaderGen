#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeNamespaceImport : CodeObject
    {
        public CodeNamespaceImport();
        public CodeNamespaceImport(string nameSpace);

        public CodeLinePragma LinePragma { get; set; }
        public string Namespace { get; set; }
    }
}
