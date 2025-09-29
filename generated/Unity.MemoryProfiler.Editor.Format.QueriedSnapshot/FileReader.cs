#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

using System;
using Unity.Collections;
using Unity.MemoryProfiler.Editor.Containers;

namespace Unity.MemoryProfiler.Editor.Format.QueriedSnapshot
{
    public struct FileReader : IDisposable, IFileReader, IReader
    {

        public bool HasOpenFile { get; }
        public string FullPath { get; }
        public FormatVersion FormatVersion { get; }
        public uint FormatVersionNumeric { get; }

        public ReadError Open(string filePath);
        public EntryFormat GetEntryFormat(EntryType type);
        public long GetSizeForEntryRange(EntryType entry, long offset, long count);
        public uint GetEntryCount(EntryType entry);
        public GenericReadOperation Read(EntryType entry, DynamicArray<byte> buffer, long offset, long count);
        public GenericReadOperation Read(EntryType entry, long offset, long count, Allocator allocator);
        public ReadError ReadUnsafe(EntryType entry, void* buffer, long bufferLength, long offset, long count);
        public GenericReadOperation AsyncRead(EntryType entry, long offset, long count, Allocator allocator);
        public GenericReadOperation AsyncRead(EntryType entry, DynamicArray<byte> buffer, long offset, long count);
        public void Close();
        public void Dispose();
    }
}
