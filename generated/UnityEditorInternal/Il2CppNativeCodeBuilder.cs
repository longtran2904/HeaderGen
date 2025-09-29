#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEditorInternal
{
    public abstract class Il2CppNativeCodeBuilder
    {
        public Il2CppNativeCodeBuilder(string baselibLibraryDirectory);

        public abstract string CompilerPlatform { get; }
        public abstract string CompilerArchitecture { get; }
        public string BaselibLibraryDirectory { get; }
        public virtual string CompilerFlags { get; }
        public virtual string LinkerFlags { get; }
        public virtual bool SetsUpEnvironment { get; }
        public virtual string CacheDirectory { get; }
        public virtual string PluginPath { get; }
        public virtual IEnumerable<string> AdditionalIl2CPPArguments { get; }
        public virtual bool LinkLibIl2CppStatically { get; }

        public virtual IEnumerable<string> ConvertIncludesToFullPaths(IEnumerable<string> relativeIncludePaths);
        public virtual string ConvertOutputFileToFullPath(string outputFileRelativePath);
        public void SetupStartInfo(ProcessStartInfo startInfo);
        protected virtual void SetupEnvironment(ProcessStartInfo startInfo);
    }
}
