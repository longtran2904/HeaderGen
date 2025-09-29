#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.IO;
using System.Reflection;

namespace System.CodeDom.Compiler
{
    public abstract class CodeGenerator : ICodeGenerator
    {

        protected CodeGenerator();

        protected CodeTypeDeclaration CurrentClass { get; }
        protected string CurrentTypeName { get; }
        protected CodeTypeMember CurrentMember { get; }
        protected string CurrentMemberName { get; }
        protected bool IsCurrentInterface { get; }
        protected bool IsCurrentClass { get; }
        protected bool IsCurrentStruct { get; }
        protected bool IsCurrentEnum { get; }
        protected bool IsCurrentDelegate { get; }
        protected int Indent { get; set; }
        protected abstract string NullToken { get; }
        protected TextWriter Output { get; }
        protected CodeGeneratorOptions Options { get; }

        protected virtual void GenerateDirectives(CodeDirectiveCollection directives);
        protected void GenerateNamespaces(CodeCompileUnit e);
        protected void GenerateTypes(CodeNamespace e);
        public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
        protected void GenerateExpression(CodeExpression e);
        protected virtual void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e);
        protected virtual void GenerateCompileUnit(CodeCompileUnit e);
        protected virtual void GenerateNamespace(CodeNamespace e);
        protected void GenerateNamespaceImports(CodeNamespace e);
        protected void GenerateStatement(CodeStatement e);
        protected void GenerateStatements(CodeStatementCollection stmts);
        protected virtual void OutputAttributeDeclarations(CodeAttributeDeclarationCollection attributes);
        protected virtual void OutputAttributeArgument(CodeAttributeArgument arg);
        protected virtual void OutputDirection(FieldDirection dir);
        protected virtual void OutputFieldScopeModifier(MemberAttributes attributes);
        protected virtual void OutputMemberAccessModifier(MemberAttributes attributes);
        protected virtual void OutputMemberScopeModifier(MemberAttributes attributes);
        protected abstract void OutputType(CodeTypeReference typeRef);
        protected virtual void OutputTypeAttributes(TypeAttributes attributes, bool isStruct, bool isEnum);
        protected virtual void OutputTypeNamePair(CodeTypeReference typeRef, string name);
        protected virtual void OutputIdentifier(string ident);
        protected virtual void OutputExpressionList(CodeExpressionCollection expressions);
        protected virtual void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems);
        protected virtual void OutputOperator(CodeBinaryOperatorType op);
        protected virtual void OutputParameters(CodeParameterDeclarationExpressionCollection parameters);
        protected abstract void GenerateArrayCreateExpression(CodeArrayCreateExpression e);
        protected abstract void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e);
        protected virtual void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e);
        protected virtual void ContinueOnNewLine(string st);
        protected abstract void GenerateCastExpression(CodeCastExpression e);
        protected abstract void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e);
        protected abstract void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e);
        protected abstract void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e);
        protected abstract void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e);
        protected abstract void GenerateIndexerExpression(CodeIndexerExpression e);
        protected abstract void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e);
        protected abstract void GenerateSnippetExpression(CodeSnippetExpression e);
        protected abstract void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e);
        protected abstract void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e);
        protected abstract void GenerateEventReferenceExpression(CodeEventReferenceExpression e);
        protected abstract void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e);
        protected abstract void GenerateObjectCreateExpression(CodeObjectCreateExpression e);
        protected virtual void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e);
        protected virtual void GenerateDirectionExpression(CodeDirectionExpression e);
        protected virtual void GeneratePrimitiveExpression(CodePrimitiveExpression e);
        protected virtual void GenerateSingleFloatValue(float s);
        protected virtual void GenerateDoubleValue(double d);
        protected virtual void GenerateDecimalValue(decimal d);
        protected virtual void GenerateDefaultValueExpression(CodeDefaultValueExpression e);
        protected abstract void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e);
        protected abstract void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e);
        protected abstract void GenerateThisReferenceExpression(CodeThisReferenceExpression e);
        protected virtual void GenerateTypeReferenceExpression(CodeTypeReferenceExpression e);
        protected virtual void GenerateTypeOfExpression(CodeTypeOfExpression e);
        protected abstract void GenerateExpressionStatement(CodeExpressionStatement e);
        protected abstract void GenerateIterationStatement(CodeIterationStatement e);
        protected abstract void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e);
        protected virtual void GenerateCommentStatement(CodeCommentStatement e);
        protected virtual void GenerateCommentStatements(CodeCommentStatementCollection e);
        protected abstract void GenerateComment(CodeComment e);
        protected abstract void GenerateMethodReturnStatement(CodeMethodReturnStatement e);
        protected abstract void GenerateConditionStatement(CodeConditionStatement e);
        protected abstract void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e);
        protected abstract void GenerateAssignStatement(CodeAssignStatement e);
        protected abstract void GenerateAttachEventStatement(CodeAttachEventStatement e);
        protected abstract void GenerateRemoveEventStatement(CodeRemoveEventStatement e);
        protected abstract void GenerateGotoStatement(CodeGotoStatement e);
        protected abstract void GenerateLabeledStatement(CodeLabeledStatement e);
        protected virtual void GenerateSnippetStatement(CodeSnippetStatement e);
        protected abstract void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e);
        protected abstract void GenerateLinePragmaStart(CodeLinePragma e);
        protected abstract void GenerateLinePragmaEnd(CodeLinePragma e);
        protected abstract void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c);
        protected abstract void GenerateField(CodeMemberField e);
        protected abstract void GenerateSnippetMember(CodeSnippetTypeMember e);
        protected abstract void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c);
        protected abstract void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c);
        protected abstract void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c);
        protected abstract void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c);
        protected abstract void GenerateTypeConstructor(CodeTypeConstructor e);
        protected abstract void GenerateTypeStart(CodeTypeDeclaration e);
        protected abstract void GenerateTypeEnd(CodeTypeDeclaration e);
        protected virtual void GenerateCompileUnitStart(CodeCompileUnit e);
        protected virtual void GenerateCompileUnitEnd(CodeCompileUnit e);
        protected abstract void GenerateNamespaceStart(CodeNamespace e);
        protected abstract void GenerateNamespaceEnd(CodeNamespace e);
        protected abstract void GenerateNamespaceImport(CodeNamespaceImport e);
        protected abstract void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes);
        protected abstract void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes);
        protected abstract bool Supports(GeneratorSupport support);
        protected abstract bool IsValidIdentifier(string value);
        protected virtual void ValidateIdentifier(string value);
        protected abstract string CreateEscapedIdentifier(string value);
        protected abstract string CreateValidIdentifier(string value);
        protected abstract string GetTypeOutput(CodeTypeReference value);
        protected abstract string QuoteSnippetString(string value);
        public static bool IsValidLanguageIndependentIdentifier(string value);
        public static void ValidateIdentifiers(CodeObject e);
    }
}
