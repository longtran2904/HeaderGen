#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.IO
{
    public sealed class DirectoryInfo : FileSystemInfo
    {
        public DirectoryInfo(string path);

        public override string Name { get; }
        public DirectoryInfo Parent { get; }
        public DirectoryInfo Root { get; }
        public override bool Exists { get; }

        public DirectoryInfo CreateSubdirectory(string path);
        public void Create();
        public FileInfo[] GetFiles();
        public FileInfo[] GetFiles(string searchPattern);
        public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption);
        public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions);
        public FileSystemInfo[] GetFileSystemInfos();
        public FileSystemInfo[] GetFileSystemInfos(string searchPattern);
        public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
        public FileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);
        public DirectoryInfo[] GetDirectories();
        public DirectoryInfo[] GetDirectories(string searchPattern);
        public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);
        public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions);
        public IEnumerable<DirectoryInfo> EnumerateDirectories();
        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern);
        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);
        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions);
        public IEnumerable<FileInfo> EnumerateFiles();
        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern);
        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);
        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions);
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos();
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);
        public void MoveTo(string destDirName);
        public override void Delete();
        public void Delete(bool recursive);
    }
}
