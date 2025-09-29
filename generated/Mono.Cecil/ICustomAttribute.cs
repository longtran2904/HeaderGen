#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public interface ICustomAttribute
    {
        TypeReference AttributeType { get; }
        bool HasFields { get; }
        bool HasProperties { get; }
        Collection<CustomAttributeNamedArgument> Fields { get; }
        Collection<CustomAttributeNamedArgument> Properties { get; }
    }
}
