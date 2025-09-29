#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.Runtime.Versioning;

namespace System.IO
{
    public static class Directory
    {
        public static DirectoryInfo GetParent(string path);
        public static DirectoryInfo CreateDirectory(string path);
        [UnsupportedOSPlatform("windows")]
        public static DirectoryInfo CreateDirectory(string path, UnixFileMode unixCreateMode);
        public static DirectoryInfo CreateTempSubdirectory(string prefix = null);
        public static bool Exists(string path);
        public static void SetCreationTime(string path, DateTime creationTime);
        public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        public static DateTime GetCreationTime(string path);
        public static DateTime GetCreationTimeUtc(string path);
        public static void SetLastWriteTime(string path, DateTime lastWriteTime);
        public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
        public static DateTime GetLastWriteTime(string path);
        public static DateTime GetLastWriteTimeUtc(string path);
        public static void SetLastAccessTime(string path, DateTime lastAccessTime);
        public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        public static DateTime GetLastAccessTime(string path);
        public static DateTime GetLastAccessTimeUtc(string path);
        public static string[] GetFiles(string path);
        public static string[] GetFiles(string path, string searchPattern);
        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
        public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
        public static string[] GetDirectories(string path);
        public static string[] GetDirectories(string path, string searchPattern);
        public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
        public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
        public static string[] GetFileSystemEntries(string path);
        public static string[] GetFileSystemEntries(string path, string searchPattern);
        public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        public static string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
        public static IEnumerable<string> EnumerateDirectories(string path);
        public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
        public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);
        public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
        public static IEnumerable<string> EnumerateFiles(string path);
        public static IEnumerable<string> EnumerateFiles(string path, string searchPattern);
        public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
        public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
        public static IEnumerable<string> EnumerateFileSystemEntries(string path);
        public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
        public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
        public static string GetDirectoryRoot(string path);
        public static string GetCurrentDirectory();
        public static void SetCurrentDirectory(string path);
        public static void Move(string sourceDirName, string destDirName);
        public static void Delete(string path);
        public static void Delete(string path, bool recursive);
        public static string[] GetLogicalDrives();
        public static FileSystemInfo CreateSymbolicLink(string path, string pathToTarget);
        public static FileSystemInfo ResolveLinkTarget(string linkPath, bool returnFinalTarget);
    }
}
