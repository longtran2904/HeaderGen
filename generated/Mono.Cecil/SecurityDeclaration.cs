#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class SecurityDeclaration
    {
        public SecurityDeclaration(SecurityAction action);
        public SecurityDeclaration(SecurityAction action, byte[] blob);

        public SecurityAction Action { get; set; }
        public bool HasSecurityAttributes { get; }
        public Collection<SecurityAttribute> SecurityAttributes { get; }

        public byte[] GetBlob();
    }
}
