#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    public abstract class BaseAssemblyResolver : IAssemblyResolver, IDisposable
    {
        protected BaseAssemblyResolver();

        public event AssemblyResolveEventHandler ResolveFailure;

        public void AddSearchDirectory(string directory);
        public void RemoveSearchDirectory(string directory);
        public string[] GetSearchDirectories();
        public virtual AssemblyDefinition Resolve(AssemblyNameReference name);
        public virtual AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
