#region Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.CompilationPipeline.Common.dll
#endregion

namespace Unity.CompilationPipeline.Common.ILPostProcessing
{
    public interface ICompiledAssembly
    {

        InMemoryAssembly InMemoryAssembly { get; }
        string Name { get; }
        string[] References { get; }
        string[] Defines { get; }
    }
}
