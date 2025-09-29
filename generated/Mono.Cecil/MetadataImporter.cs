#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public class MetadataImporter : IMetadataImporter
    {
        public MetadataImporter(ModuleDefinition module);

        public virtual TypeReference ImportReference(TypeReference type, IGenericParameterProvider context);
        public virtual FieldReference ImportReference(FieldReference field, IGenericParameterProvider context);
        public virtual MethodReference ImportReference(MethodReference method, IGenericParameterProvider context);
    }
}
