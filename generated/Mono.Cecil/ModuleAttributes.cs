#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    [Flags]
    public enum ModuleAttributes
    {
        ILOnly = 1,
        Required32Bit = 2,
        ILLibrary = 4,
        StrongNameSigned = 8,
        Preferred32Bit = 131072
    }
}
