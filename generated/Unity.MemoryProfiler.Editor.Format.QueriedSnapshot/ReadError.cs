#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

namespace Unity.MemoryProfiler.Editor.Format.QueriedSnapshot
{
    public enum ReadError
    {

        None = 0,
        Success = 1,
        InProgress = 2,
        FileReadFailed = 3,
        FileNotFound = 4,
        InvalidHeaderSignature = 5,
        InvalidDirectorySignature = 6,
        InvalidFooterSignature = 7,
        InvalidChapterLocation = 8,
        InvalidChapterSectionVersion = 9,
        InvalidBlockSectionVersion = 10,
        InvalidBlockSectionCount = 11,
        InvalidEntryFormat = 12,
        EmptyFormatEntry = 13
    }
}
