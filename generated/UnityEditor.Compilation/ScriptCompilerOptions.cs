#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Compilation
{
    public class ScriptCompilerOptions
    {
        public ScriptCompilerOptions();

        public string RoslynAnalyzerRulesetPath { get; set; }
        public string[] RoslynAnalyzerDllPaths { get; set; }
        public string[] RoslynAdditionalFilePaths { get; set; }
        public string AnalyzerConfigPath { get; set; }
        public bool AllowUnsafeCode { get; set; }
        [Obsolete("Use of reference assemblies is always enabled", True)]
        public bool EmitReferenceAssembly { get; set; }
        public string[] AdditionalCompilerArguments { get; set; }
        public CodeOptimization CodeOptimization { get; set; }
        public ApiCompatibilityLevel ApiCompatibilityLevel { get; set; }
        public string[] ResponseFiles { get; set; }
        public string LanguageVersion { get; }
    }
}
