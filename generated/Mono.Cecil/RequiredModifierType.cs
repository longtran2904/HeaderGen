#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public sealed class RequiredModifierType : TypeSpecification, IModifierType
    {
        public RequiredModifierType(TypeReference modifierType, TypeReference type);

        public TypeReference ModifierType { get; set; }
        public override string Name { get; }
        public override string FullName { get; }
        public override bool IsValueType { get; set; }
        public override bool IsRequiredModifier { get; }
        public override bool ContainsGenericParameter { get; }
    }
}
