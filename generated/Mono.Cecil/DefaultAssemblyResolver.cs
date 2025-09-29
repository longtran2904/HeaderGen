#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public class DefaultAssemblyResolver : BaseAssemblyResolver
    {
        public DefaultAssemblyResolver();

        public override AssemblyDefinition Resolve(AssemblyNameReference name);
        protected void RegisterAssembly(AssemblyDefinition assembly);
        protected override void Dispose(bool disposing);
    }
}
