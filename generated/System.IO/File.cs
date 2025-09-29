#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public static class File
    {

        public static StreamReader OpenText(string path);
        public static StreamWriter CreateText(string path);
        public static StreamWriter AppendText(string path);
        public static void Copy(string sourceFileName, string destFileName);
        public static void Copy(string sourceFileName, string destFileName, bool overwrite);
        public static FileStream Create(string path);
        public static FileStream Create(string path, int bufferSize);
        public static FileStream Create(string path, int bufferSize, FileOptions options);
        public static void Delete(string path);
        public static bool Exists(string path);
        public static FileStream Open(string path, FileStreamOptions options);
        public static FileStream Open(string path, FileMode mode);
        public static FileStream Open(string path, FileMode mode, FileAccess access);
        public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
        public static SafeFileHandle OpenHandle(string path, FileMode mode = FileMode.Open, FileAccess access = FileAccess.Read, FileShare share = FileShare.Read, FileOptions options = FileOptions.None, long preallocationSize = 0);
        public static void SetCreationTime(string path, DateTime creationTime);
        public static void SetCreationTime(SafeFileHandle fileHandle, DateTime creationTime);
        public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        public static void SetCreationTimeUtc(SafeFileHandle fileHandle, DateTime creationTimeUtc);
        public static DateTime GetCreationTime(string path);
        public static DateTime GetCreationTime(SafeFileHandle fileHandle);
        public static DateTime GetCreationTimeUtc(string path);
        public static DateTime GetCreationTimeUtc(SafeFileHandle fileHandle);
        public static void SetLastAccessTime(string path, DateTime lastAccessTime);
        public static void SetLastAccessTime(SafeFileHandle fileHandle, DateTime lastAccessTime);
        public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        public static void SetLastAccessTimeUtc(SafeFileHandle fileHandle, DateTime lastAccessTimeUtc);
        public static DateTime GetLastAccessTime(string path);
        public static DateTime GetLastAccessTime(SafeFileHandle fileHandle);
        public static DateTime GetLastAccessTimeUtc(string path);
        public static DateTime GetLastAccessTimeUtc(SafeFileHandle fileHandle);
        public static void SetLastWriteTime(string path, DateTime lastWriteTime);
        public static void SetLastWriteTime(SafeFileHandle fileHandle, DateTime lastWriteTime);
        public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
        public static void SetLastWriteTimeUtc(SafeFileHandle fileHandle, DateTime lastWriteTimeUtc);
        public static DateTime GetLastWriteTime(string path);
        public static DateTime GetLastWriteTime(SafeFileHandle fileHandle);
        public static DateTime GetLastWriteTimeUtc(string path);
        public static DateTime GetLastWriteTimeUtc(SafeFileHandle fileHandle);
        public static FileAttributes GetAttributes(string path);
        public static FileAttributes GetAttributes(SafeFileHandle fileHandle);
        public static void SetAttributes(string path, FileAttributes fileAttributes);
        public static void SetAttributes(SafeFileHandle fileHandle, FileAttributes fileAttributes);
        [UnsupportedOSPlatform("windows")]
        public static UnixFileMode GetUnixFileMode(string path);
        [UnsupportedOSPlatform("windows")]
        public static UnixFileMode GetUnixFileMode(SafeFileHandle fileHandle);
        [UnsupportedOSPlatform("windows")]
        public static void SetUnixFileMode(string path, UnixFileMode mode);
        [UnsupportedOSPlatform("windows")]
        public static void SetUnixFileMode(SafeFileHandle fileHandle, UnixFileMode mode);
        public static FileStream OpenRead(string path);
        public static FileStream OpenWrite(string path);
        public static string ReadAllText(string path);
        public static string ReadAllText(string path, Encoding encoding);
        public static void WriteAllText(string path, string contents);
        public static void WriteAllText(string path, string contents, Encoding encoding);
        public static byte[] ReadAllBytes(string path);
        public static void WriteAllBytes(string path, byte[] bytes);
        public static string[] ReadAllLines(string path);
        public static string[] ReadAllLines(string path, Encoding encoding);
        public static IEnumerable<string> ReadLines(string path);
        public static IEnumerable<string> ReadLines(string path, Encoding encoding);
        public static IAsyncEnumerable<string> ReadLinesAsync(string path, CancellationToken cancellationToken = null);
        public static IAsyncEnumerable<string> ReadLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = null);
        public static void WriteAllLines(string path, string[] contents);
        public static void WriteAllLines(string path, IEnumerable<string> contents);
        public static void WriteAllLines(string path, string[] contents, Encoding encoding);
        public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);
        public static void AppendAllText(string path, string contents);
        public static void AppendAllText(string path, string contents, Encoding encoding);
        public static void AppendAllLines(string path, IEnumerable<string> contents);
        public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
        public static void Move(string sourceFileName, string destFileName);
        public static void Move(string sourceFileName, string destFileName, bool overwrite);
        [SupportedOSPlatform("windows")]
        public static void Encrypt(string path);
        [SupportedOSPlatform("windows")]
        public static void Decrypt(string path);
        public static Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = null);
        public static Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = null);
        public static Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = null);
        public static Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = null);
        public static Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = null);
        public static Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = null);
        public static Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = null);
        public static Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = null);
        public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = null);
        public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = null);
        public static Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = null);
        public static Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = null);
        public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = null);
        public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = null);
        public static FileSystemInfo CreateSymbolicLink(string path, string pathToTarget);
        public static FileSystemInfo ResolveLinkTarget(string linkPath, bool returnFinalTarget);
    }
}
