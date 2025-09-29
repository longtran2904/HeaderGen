#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class GenericInstanceType : TypeSpecification, IGenericInstance
    {

        public GenericInstanceType(TypeReference type);

        public bool HasGenericArguments { get; }
        public Collection<TypeReference> GenericArguments { get; }
        public override TypeReference DeclaringType { get; set; }
        public override string FullName { get; }
        public override bool IsGenericInstance { get; }
        public override bool ContainsGenericParameter { get; }
    }
}
