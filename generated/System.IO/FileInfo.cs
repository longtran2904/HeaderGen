#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.IO
{
    public sealed class FileInfo : FileSystemInfo
    {
        public FileInfo(string fileName);

        public override string Name { get; }
        public long Length { get; }
        public string DirectoryName { get; }
        public DirectoryInfo Directory { get; }
        public bool IsReadOnly { get; set; }
        public override bool Exists { get; }

        public FileStream Open(FileStreamOptions options);
        public StreamReader OpenText();
        public StreamWriter CreateText();
        public StreamWriter AppendText();
        public FileInfo CopyTo(string destFileName);
        public FileInfo CopyTo(string destFileName, bool overwrite);
        public FileStream Create();
        public override void Delete();
        public FileStream Open(FileMode mode);
        public FileStream Open(FileMode mode, FileAccess access);
        public FileStream Open(FileMode mode, FileAccess access, FileShare share);
        public FileStream OpenRead();
        public FileStream OpenWrite();
        public void MoveTo(string destFileName);
        public void MoveTo(string destFileName, bool overwrite);
        public FileInfo Replace(string destinationFileName, string destinationBackupFileName);
        public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
        [SupportedOSPlatform("windows")]
        public void Decrypt();
        [SupportedOSPlatform("windows")]
        public void Encrypt();
    }
}
