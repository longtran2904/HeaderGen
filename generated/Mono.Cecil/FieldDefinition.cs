#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class FieldDefinition : FieldReference, IConstantProvider, ICustomAttributeProvider, IMarshalInfoProvider, IMemberDefinition
    {
        public FieldDefinition(string name, FieldAttributes attributes, TypeReference fieldType);

        public bool HasLayoutInfo { get; }
        public int Offset { get; set; }
        public int RVA { get; }
        public byte[] InitialValue { get; set; }
        public FieldAttributes Attributes { get; set; }
        public bool HasConstant { get; set; }
        public object Constant { get; set; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public bool HasMarshalInfo { get; }
        public MarshalInfo MarshalInfo { get; set; }
        public bool IsCompilerControlled { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsFamilyAndAssembly { get; set; }
        public bool IsAssembly { get; set; }
        public bool IsFamily { get; set; }
        public bool IsFamilyOrAssembly { get; set; }
        public bool IsPublic { get; set; }
        public bool IsStatic { get; set; }
        public bool IsInitOnly { get; set; }
        public bool IsLiteral { get; set; }
        public bool IsNotSerialized { get; set; }
        public bool IsSpecialName { get; set; }
        public bool IsPInvokeImpl { get; set; }
        public bool IsRuntimeSpecialName { get; set; }
        public bool HasDefault { get; set; }
        public override bool IsDefinition { get; }
        public TypeDefinition DeclaringType { get; set; }

        public override FieldDefinition Resolve();
    }
}
