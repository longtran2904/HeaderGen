#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class EventDefinition : EventReference, ICustomAttributeProvider, IMemberDefinition
    {

        public EventDefinition(string name, EventAttributes attributes, TypeReference eventType);

        public EventAttributes Attributes { get; set; }
        public MethodDefinition AddMethod { get; set; }
        public MethodDefinition InvokeMethod { get; set; }
        public MethodDefinition RemoveMethod { get; set; }
        public bool HasOtherMethods { get; }
        public Collection<MethodDefinition> OtherMethods { get; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public bool IsSpecialName { get; set; }
        public bool IsRuntimeSpecialName { get; set; }
        public TypeDefinition DeclaringType { get; set; }
        public override bool IsDefinition { get; }

        public override EventDefinition Resolve();
    }
}
