#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public class MetadataResolver : IMetadataResolver
    {

        public MetadataResolver(IAssemblyResolver assemblyResolver);

        public IAssemblyResolver AssemblyResolver { get; }

        public virtual TypeDefinition Resolve(TypeReference type);
        public virtual FieldDefinition Resolve(FieldReference field);
        public virtual MethodDefinition Resolve(MethodReference method);
        public static MethodDefinition GetMethod(Collection<MethodDefinition> methods, MethodReference reference);
    }
}
