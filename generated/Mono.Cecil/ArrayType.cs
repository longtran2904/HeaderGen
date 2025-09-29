#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class ArrayType : TypeSpecification
    {

        public ArrayType(TypeReference type);
        public ArrayType(TypeReference type, int rank);

        public Collection<ArrayDimension> Dimensions { get; }
        public int Rank { get; }
        public bool IsVector { get; }
        public override bool IsValueType { get; set; }
        public override string Name { get; }
        public override string FullName { get; }
        public override bool IsArray { get; }
    }
}
