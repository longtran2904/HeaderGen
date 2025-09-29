#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Compilation
{
    public class AssemblyBuilder
    {

        public AssemblyBuilder(string assemblyPath, params string[] scriptPaths);

        public string[] scriptPaths { get; }
        public string assemblyPath { get; }
        public string[] additionalDefines { get; set; }
        public string[] additionalReferences { get; set; }
        public string[] excludeReferences { get; set; }
        public ScriptCompilerOptions compilerOptions { get; set; }
        public ReferencesOptions referencesOptions { get; set; }
        public AssemblyBuilderFlags flags { get; set; }
        public BuildTargetGroup buildTargetGroup { get; set; }
        public BuildTarget buildTarget { get; set; }
        public string[] defaultReferences { get; }
        public string[] defaultDefines { get; }
        public AssemblyBuilderStatus status { get; }

        public event Action<string> buildStarted;
        public event Action<string, CompilerMessage[]> buildFinished;

        public bool Build();
    }
}
