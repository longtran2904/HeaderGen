#region Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.CompilationPipeline.Common.dll
#endregion

namespace Unity.CompilationPipeline.Common.ILPostProcessing
{
    public class InMemoryAssembly
    {
        public InMemoryAssembly(byte[] peData, byte[] pdbData);

        public byte[] PeData { get; set; }
        public byte[] PdbData { get; set; }
    }
}
