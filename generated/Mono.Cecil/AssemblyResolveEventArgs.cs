#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    public sealed class AssemblyResolveEventArgs : EventArgs
    {
        public AssemblyResolveEventArgs(AssemblyNameReference reference);

        public AssemblyNameReference AssemblyReference { get; }
    }
}
