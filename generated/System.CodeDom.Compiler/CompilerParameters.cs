#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections.Specialized;

namespace System.CodeDom.Compiler
{
    public class CompilerParameters
    {

        public CompilerParameters();
        public CompilerParameters(string[] assemblyNames);
        public CompilerParameters(string[] assemblyNames, string outputName);
        public CompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation);

        public string CoreAssemblyFileName { get; set; }
        public bool GenerateExecutable { get; set; }
        public bool GenerateInMemory { get; set; }
        public StringCollection ReferencedAssemblies { get; }
        public string MainClass { get; set; }
        public string OutputAssembly { get; set; }
        public TempFileCollection TempFiles { get; set; }
        public bool IncludeDebugInformation { get; set; }
        public bool TreatWarningsAsErrors { get; set; }
        public int WarningLevel { get; set; }
        public string CompilerOptions { get; set; }
        public string Win32Resource { get; set; }
        public StringCollection EmbeddedResources { get; }
        public StringCollection LinkedResources { get; }
        public nint UserToken { get; set; }
    }
}
