#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace System.CodeDom.Compiler
{
    [ToolboxItem(False)]
    public abstract class CodeDomProvider : Component
    {

        protected CodeDomProvider();

        public virtual string FileExtension { get; }
        public virtual LanguageOptions LanguageOptions { get; }

        public static CodeDomProvider CreateProvider(string language, IDictionary<string, string> providerOptions);
        public static CodeDomProvider CreateProvider(string language);
        public static string GetLanguageFromExtension(string extension);
        public static bool IsDefinedLanguage(string language);
        public static bool IsDefinedExtension(string extension);
        public static CompilerInfo GetCompilerInfo(string language);
        public static CompilerInfo[] GetAllCompilerInfo();
        [Obsolete("ICodeGenerator has been deprecated. Use the methods directly on the CodeDomProvider class instead. Classes inheriting from CodeDomProvider must still implement this interface, and should suppress this warning or also mark this method as obsolete.")]
        public abstract ICodeGenerator CreateGenerator();
        public virtual ICodeGenerator CreateGenerator(TextWriter output);
        public virtual ICodeGenerator CreateGenerator(string fileName);
        [Obsolete("ICodeCompiler has been deprecated. Use the methods directly on the CodeDomProvider class instead. Classes inheriting from CodeDomProvider must still implement this interface, and should suppress this warning or also mark this method as obsolete.")]
        public abstract ICodeCompiler CreateCompiler();
        [Obsolete("ICodeParser has been deprecated. Use the methods directly on the CodeDomProvider class instead. Classes inheriting from CodeDomProvider must still implement this interface, and should suppress this warning or also mark this method as obsolete.")]
        public virtual ICodeParser CreateParser();
        public virtual TypeConverter GetConverter(Type type);
        public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, params CodeCompileUnit[] compilationUnits);
        public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, params string[] fileNames);
        public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, params string[] sources);
        public virtual bool IsValidIdentifier(string value);
        public virtual string CreateEscapedIdentifier(string value);
        public virtual string CreateValidIdentifier(string value);
        public virtual string GetTypeOutput(CodeTypeReference type);
        public virtual bool Supports(GeneratorSupport generatorSupport);
        public virtual void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options);
        public virtual void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options);
        public virtual void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options);
        public virtual void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options);
        public virtual void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options);
        public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
        public virtual CodeCompileUnit Parse(TextReader codeStream);
    }
}
