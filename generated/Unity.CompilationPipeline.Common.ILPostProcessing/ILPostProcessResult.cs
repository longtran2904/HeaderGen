#region Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.CompilationPipeline.Common.dll
#endregion

using System.Collections.Generic;
using Unity.CompilationPipeline.Common.Diagnostics;

namespace Unity.CompilationPipeline.Common.ILPostProcessing
{
    public class ILPostProcessResult
    {

        public ILPostProcessResult(InMemoryAssembly inMemoryAssembly);
        public ILPostProcessResult(InMemoryAssembly inMemoryAssembly, List<DiagnosticMessage> diagnostics);

        public InMemoryAssembly InMemoryAssembly { get; set; }
        public List<DiagnosticMessage> Diagnostics { get; set; }
    }
}
