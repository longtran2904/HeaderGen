#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom.Compiler
{
    public abstract class CodeCompiler : CodeGenerator, ICodeCompiler
    {

        protected CodeCompiler();

        protected abstract string FileExtension { get; }
        protected abstract string CompilerName { get; }

        protected virtual CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e);
        protected virtual CompilerResults FromFile(CompilerParameters options, string fileName);
        protected virtual CompilerResults FromSource(CompilerParameters options, string source);
        protected virtual CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea);
        protected virtual CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames);
        protected abstract void ProcessCompilerOutputLine(CompilerResults results, string line);
        protected abstract string CmdArgsFromParameters(CompilerParameters options);
        protected virtual string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs);
        protected virtual CompilerResults FromSourceBatch(CompilerParameters options, string[] sources);
        protected static string JoinStringArray(string[] sa, string separator);
    }
}
