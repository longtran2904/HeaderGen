#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public abstract class MemberReference : IMetadataTokenProvider
    {
        public virtual string Name { get; set; }
        public abstract string FullName { get; }
        public virtual TypeReference DeclaringType { get; set; }
        public MetadataToken MetadataToken { get; set; }
        public bool IsWindowsRuntimeProjection { get; }
        public virtual ModuleDefinition Module { get; }
        public virtual bool IsDefinition { get; }
        public virtual bool ContainsGenericParameter { get; }

        public IMemberDefinition Resolve();
        protected abstract IMemberDefinition ResolveDefinition();
        public override string ToString();
    }
}
