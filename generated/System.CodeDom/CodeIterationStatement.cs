#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeIterationStatement : CodeStatement
    {

        public CodeIterationStatement();
        public CodeIterationStatement(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, params CodeStatement[] statements);

        public CodeStatement InitStatement { get; set; }
        public CodeExpression TestExpression { get; set; }
        public CodeStatement IncrementStatement { get; set; }
        public CodeStatementCollection Statements { get; }
    }
}
