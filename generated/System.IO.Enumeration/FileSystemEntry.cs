#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.IO.Enumeration
{
    [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
    public ref struct FileSystemEntry
    {

        public ReadOnlySpan<char> Directory { get; }
        public ReadOnlySpan<char> RootDirectory { get; }
        public ReadOnlySpan<char> OriginalRootDirectory { get; }
        public ReadOnlySpan<char> FileName { get; }
        public FileAttributes Attributes { get; }
        public long Length { get; }
        public DateTimeOffset CreationTimeUtc { get; }
        public DateTimeOffset LastAccessTimeUtc { get; }
        public DateTimeOffset LastWriteTimeUtc { get; }
        public bool IsDirectory { get; }
        public bool IsHidden { get; }

        public string ToSpecifiedFullPath();
        public FileSystemInfo ToFileSystemInfo();
        public string ToFullPath();
    }
}
