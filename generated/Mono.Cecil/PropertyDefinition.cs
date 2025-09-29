#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class PropertyDefinition : PropertyReference, IConstantProvider, ICustomAttributeProvider, IMemberDefinition
    {

        public PropertyDefinition(string name, PropertyAttributes attributes, TypeReference propertyType);

        public PropertyAttributes Attributes { get; set; }
        public bool HasThis { get; set; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public MethodDefinition GetMethod { get; set; }
        public MethodDefinition SetMethod { get; set; }
        public bool HasOtherMethods { get; }
        public Collection<MethodDefinition> OtherMethods { get; }
        public bool HasParameters { get; }
        public override Collection<ParameterDefinition> Parameters { get; }
        public bool HasConstant { get; set; }
        public object Constant { get; set; }
        public bool IsSpecialName { get; set; }
        public bool IsRuntimeSpecialName { get; set; }
        public bool HasDefault { get; set; }
        public TypeDefinition DeclaringType { get; set; }
        public override bool IsDefinition { get; }
        public override string FullName { get; }

        public override PropertyDefinition Resolve();
    }
}
