#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.IO
{
    public class EnumerationOptions
    {

        public EnumerationOptions();

        public bool RecurseSubdirectories { get; set; }
        public bool IgnoreInaccessible { get; set; }
        public int BufferSize { get; set; }
        public FileAttributes AttributesToSkip { get; set; }
        public MatchType MatchType { get; set; }
        public MatchCasing MatchCasing { get; set; }
        public int MaxRecursionDepth { get; set; }
        public bool ReturnSpecialDirectories { get; set; }
    }
}
