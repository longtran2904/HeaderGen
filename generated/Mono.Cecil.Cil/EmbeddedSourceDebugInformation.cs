#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil.Cil
{
    public sealed class EmbeddedSourceDebugInformation : CustomDebugInformation
    {

        public static Guid KindIdentifier;

        public EmbeddedSourceDebugInformation(byte[] content, bool compress);

        public byte[] Content { get; set; }
        public bool Compress { get; set; }
        public override CustomDebugInformationKind Kind { get; }
    }
}
