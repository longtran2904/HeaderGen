#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil.Cil
{
    public sealed class Document : DebugInformation
    {
        public Document(string url);

        public string Url { get; set; }
        public DocumentType Type { get; set; }
        public DocumentHashAlgorithm HashAlgorithm { get; set; }
        public DocumentLanguage Language { get; set; }
        public DocumentLanguageVendor LanguageVendor { get; set; }
        public byte[] Hash { get; set; }
    }
}
