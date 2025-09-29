#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    [Flags]
    public enum FieldAttributes
    {

        FieldAccessMask = 7,
        CompilerControlled = 0,
        Private = 1,
        FamANDAssem = 2,
        Assembly = 3,
        Family = 4,
        FamORAssem = 5,
        Public = 6,
        Static = 16,
        InitOnly = 32,
        Literal = 64,
        NotSerialized = 128,
        SpecialName = 512,
        PInvokeImpl = 8192,
        RTSpecialName = 1024,
        HasFieldMarshal = 4096,
        HasDefault = 32768,
        HasFieldRVA = 256
    }
}
