#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections.Specialized;

namespace System.CodeDom
{
    public class CodeCompileUnit : CodeObject
    {

        public CodeCompileUnit();

        public CodeNamespaceCollection Namespaces { get; }
        public StringCollection ReferencedAssemblies { get; }
        public CodeAttributeDeclarationCollection AssemblyCustomAttributes { get; }
        public CodeDirectiveCollection StartDirectives { get; }
        public CodeDirectiveCollection EndDirectives { get; }
    }
}
