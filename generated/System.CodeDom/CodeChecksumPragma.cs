#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeChecksumPragma : CodeDirective
    {
        public CodeChecksumPragma();
        public CodeChecksumPragma(string fileName, Guid checksumAlgorithmId, byte[] checksumData);

        public string FileName { get; set; }
        public Guid ChecksumAlgorithmId { get; set; }
        public byte[] ChecksumData { get; set; }
    }
}
