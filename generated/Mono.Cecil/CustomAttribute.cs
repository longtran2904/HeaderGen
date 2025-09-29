#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class CustomAttribute : ICustomAttribute
    {

        public CustomAttribute(MethodReference constructor);
        public CustomAttribute(MethodReference constructor, byte[] blob);

        public MethodReference Constructor { get; set; }
        public TypeReference AttributeType { get; }
        public bool IsResolved { get; }
        public bool HasConstructorArguments { get; }
        public Collection<CustomAttributeArgument> ConstructorArguments { get; }
        public bool HasFields { get; }
        public Collection<CustomAttributeNamedArgument> Fields { get; }
        public bool HasProperties { get; }
        public Collection<CustomAttributeNamedArgument> Properties { get; }

        public byte[] GetBlob();
    }
}
