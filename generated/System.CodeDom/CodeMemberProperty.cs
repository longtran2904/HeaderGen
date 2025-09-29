#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeMemberProperty : CodeTypeMember
    {

        public CodeMemberProperty();

        public CodeTypeReference PrivateImplementationType { get; set; }
        public CodeTypeReferenceCollection ImplementationTypes { get; }
        public CodeTypeReference Type { get; set; }
        public bool HasGet { get; set; }
        public bool HasSet { get; set; }
        public CodeStatementCollection GetStatements { get; }
        public CodeStatementCollection SetStatements { get; }
        public CodeParameterDeclarationExpressionCollection Parameters { get; }
    }
}
