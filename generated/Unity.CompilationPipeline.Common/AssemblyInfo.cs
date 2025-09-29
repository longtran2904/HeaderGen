#region Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.CompilationPipeline.Common.dll
#endregion

namespace Unity.CompilationPipeline.Common
{
    public class AssemblyInfo
    {

        public AssemblyInfo();

        public string Name { get; set; }
        public string OutputDirectory { get; set; }
        public string[] References { get; set; }
        public string[] Defines { get; set; }
        public string[] Files { get; set; }
        public bool AllowUnsafeCode { get; set; }
        public CodeOptimization CodeOptimization { get; set; }
    }
}
