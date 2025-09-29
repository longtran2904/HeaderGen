#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeTryCatchFinallyStatement : CodeStatement
    {
        public CodeTryCatchFinallyStatement();
        public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses);
        public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements);

        public CodeStatementCollection TryStatements { get; }
        public CodeCatchClauseCollection CatchClauses { get; }
        public CodeStatementCollection FinallyStatements { get; }
    }
}
