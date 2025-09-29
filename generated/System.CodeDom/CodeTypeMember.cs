#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeTypeMember : CodeObject
    {
        public CodeTypeMember();

        public string Name { get; set; }
        public MemberAttributes Attributes { get; set; }
        public CodeAttributeDeclarationCollection CustomAttributes { get; set; }
        public CodeLinePragma LinePragma { get; set; }
        public CodeCommentStatementCollection Comments { get; }
        public CodeDirectiveCollection StartDirectives { get; }
        public CodeDirectiveCollection EndDirectives { get; }
    }
}
