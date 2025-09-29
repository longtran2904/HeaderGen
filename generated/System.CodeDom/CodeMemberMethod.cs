#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeMemberMethod : CodeTypeMember
    {
        public CodeMemberMethod();

        public CodeTypeReference ReturnType { get; set; }
        public CodeStatementCollection Statements { get; }
        public CodeParameterDeclarationExpressionCollection Parameters { get; }
        public CodeTypeReference PrivateImplementationType { get; set; }
        public CodeTypeReferenceCollection ImplementationTypes { get; }
        public CodeAttributeDeclarationCollection ReturnTypeCustomAttributes { get; }
        public CodeTypeParameterCollection TypeParameters { get; }

        public event EventHandler PopulateParameters;
        public event EventHandler PopulateStatements;
        public event EventHandler PopulateImplementationTypes;
    }
}
