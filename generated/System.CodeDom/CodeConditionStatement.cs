#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeConditionStatement : CodeStatement
    {
        public CodeConditionStatement();
        public CodeConditionStatement(CodeExpression condition, params CodeStatement[] trueStatements);
        public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements);

        public CodeExpression Condition { get; set; }
        public CodeStatementCollection TrueStatements { get; }
        public CodeStatementCollection FalseStatements { get; }
    }
}
