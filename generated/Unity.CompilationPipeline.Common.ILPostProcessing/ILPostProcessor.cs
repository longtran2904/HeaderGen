#region Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.CompilationPipeline.Common.dll
#endregion

namespace Unity.CompilationPipeline.Common.ILPostProcessing
{
    public abstract class ILPostProcessor
    {

        protected ILPostProcessor();

        public abstract ILPostProcessor GetInstance();
        public abstract bool WillProcess(ICompiledAssembly compiledAssembly);
        public abstract ILPostProcessResult Process(ICompiledAssembly compiledAssembly);
    }
}
