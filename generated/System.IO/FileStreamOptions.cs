#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.IO
{
    public sealed class FileStreamOptions
    {
        public FileStreamOptions();

        public FileMode Mode { get; set; }
        public FileAccess Access { get; set; }
        public FileShare Share { get; set; }
        public FileOptions Options { get; set; }
        public long PreallocationSize { get; set; }
        public int BufferSize { get; set; }
        public UnixFileMode? UnixCreateMode { get; set; }
    }
}
