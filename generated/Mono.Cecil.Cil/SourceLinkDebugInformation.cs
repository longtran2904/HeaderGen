#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil.Cil
{
    public sealed class SourceLinkDebugInformation : CustomDebugInformation
    {

        public static Guid KindIdentifier;

        public SourceLinkDebugInformation(string content);

        public string Content { get; set; }
        public override CustomDebugInformationKind Kind { get; }
    }
}
