#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

using System;
using Unity.IO.LowLevel.Unsafe;

namespace Unity.MemoryProfiler.Editor.Format.LowLevel.IO
{
    public struct LowLevelFileReader : IDisposable
    {
        public LowLevelFileReader(string filePath);

        public long FileLength { get; }
        public bool IsCreated { get; }
        public string FilePath { get; }

        public void Dispose();
        public ReadHandle Read(ReadCommand* readCmds, uint cmdCount, ReadMode mode = ReadMode.Async);
    }
}
