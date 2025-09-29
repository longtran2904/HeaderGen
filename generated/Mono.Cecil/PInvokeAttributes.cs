#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    [Flags]
    public enum PInvokeAttributes
    {

        NoMangle = 1,
        CharSetMask = 6,
        CharSetNotSpec = 0,
        CharSetAnsi = 2,
        CharSetUnicode = 4,
        CharSetAuto = 6,
        SupportsLastError = 64,
        CallConvMask = 1792,
        CallConvWinapi = 256,
        CallConvCdecl = 512,
        CallConvStdCall = 768,
        CallConvThiscall = 1024,
        CallConvFastcall = 1280,
        BestFitMask = 48,
        BestFitEnabled = 16,
        BestFitDisabled = 32,
        ThrowOnUnmappableCharMask = 12288,
        ThrowOnUnmappableCharEnabled = 4096,
        ThrowOnUnmappableCharDisabled = 8192
    }
}
