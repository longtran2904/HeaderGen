#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public sealed class PInvokeInfo
    {

        public PInvokeInfo(PInvokeAttributes attributes, string entryPoint, ModuleReference module);

        public PInvokeAttributes Attributes { get; set; }
        public string EntryPoint { get; set; }
        public ModuleReference Module { get; set; }
        public bool IsNoMangle { get; set; }
        public bool IsCharSetNotSpec { get; set; }
        public bool IsCharSetAnsi { get; set; }
        public bool IsCharSetUnicode { get; set; }
        public bool IsCharSetAuto { get; set; }
        public bool SupportsLastError { get; set; }
        public bool IsCallConvWinapi { get; set; }
        public bool IsCallConvCdecl { get; set; }
        public bool IsCallConvStdCall { get; set; }
        public bool IsCallConvThiscall { get; set; }
        public bool IsCallConvFastcall { get; set; }
        public bool IsBestFitEnabled { get; set; }
        public bool IsBestFitDisabled { get; set; }
        public bool IsThrowOnUnmappableCharEnabled { get; set; }
        public bool IsThrowOnUnmappableCharDisabled { get; set; }
    }
}
