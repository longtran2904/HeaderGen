#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom.Compiler
{
    public interface ICodeCompiler
    {
        CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);
        CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);
        CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);
        CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);
        CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);
        CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
    }
}
