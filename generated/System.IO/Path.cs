#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.IO
{
    public static class Path
    {

        public static readonly char DirectorySeparatorChar;
        public static readonly char AltDirectorySeparatorChar;
        public static readonly char VolumeSeparatorChar;
        public static readonly char PathSeparator;
        [Obsolete("Path.InvalidPathChars has been deprecated. Use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public static readonly char[] InvalidPathChars;

        public static string ChangeExtension(string path, string extension);
        public static bool Exists(string path);
        public static string GetDirectoryName(string path);
        public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path);
        public static string GetExtension(string path);
        public static ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path);
        public static string GetFileName(string path);
        public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path);
        public static string GetFileNameWithoutExtension(string path);
        public static ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);
        public static string GetRandomFileName();
        public static bool IsPathFullyQualified(string path);
        public static bool IsPathFullyQualified(ReadOnlySpan<char> path);
        public static bool HasExtension(string path);
        public static bool HasExtension(ReadOnlySpan<char> path);
        public static string Combine(string path1, string path2);
        public static string Combine(string path1, string path2, string path3);
        public static string Combine(string path1, string path2, string path3, string path4);
        public static string Combine(params string[] paths);
        public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);
        public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);
        public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4);
        public static string Join(string path1, string path2);
        public static string Join(string path1, string path2, string path3);
        public static string Join(string path1, string path2, string path3, string path4);
        public static string Join(params string[] paths);
        public static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);
        public static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten);
        public static string GetRelativePath(string relativeTo, string path);
        public static string TrimEndingDirectorySeparator(string path);
        public static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path);
        public static bool EndsInDirectorySeparator(ReadOnlySpan<char> path);
        public static bool EndsInDirectorySeparator(string path);
        public static char[] GetInvalidFileNameChars();
        public static char[] GetInvalidPathChars();
        public static string GetFullPath(string path);
        public static string GetFullPath(string path, string basePath);
        public static string GetTempPath();
        public static string GetTempFileName();
        public static bool IsPathRooted(string path);
        public static bool IsPathRooted(ReadOnlySpan<char> path);
        public static string GetPathRoot(string path);
        public static ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path);
    }
}
