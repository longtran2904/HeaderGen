#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Compilation
{
    public class Assembly
    {
        public Assembly(string name, string outputPath, string[] sourceFiles, string[] defines, Assembly[] assemblyReferences, string[] compiledAssemblyReferences, AssemblyFlags flags);
        public Assembly(string name, string outputPath, string[] sourceFiles, string[] defines, Assembly[] assemblyReferences, string[] compiledAssemblyReferences, AssemblyFlags flags, ScriptCompilerOptions compilerOptions);
        public Assembly(string name, string outputPath, string[] sourceFiles, string[] defines, Assembly[] assemblyReferences, string[] compiledAssemblyReferences, AssemblyFlags flags, ScriptCompilerOptions compilerOptions, string rootNamespace);

        public string name { get; }
        public string rootNamespace { get; }
        public string outputPath { get; }
        public string[] sourceFiles { get; }
        public string[] defines { get; }
        public Assembly[] assemblyReferences { get; }
        public string[] compiledAssemblyReferences { get; }
        public AssemblyFlags flags { get; }
        public ScriptCompilerOptions compilerOptions { get; }
        public string[] allReferences { get; }
    }
}
