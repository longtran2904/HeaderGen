#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine.Bindings;

namespace UnityEditorInternal.Profiling.Memory.Experimental
{
    [NativeHeader("Modules/Profiler/Public/MemorySnapshot/MemorySnapshotFileWriter.h")]
    public class MemorySnapshotFileWriter : IDisposable
    {

        public MemorySnapshotFileWriter(string filepath);
        public MemorySnapshotFileWriter();

        public void Close();
        public void Open(string filename);
        public void Dispose();
        public void WriteEntry(EntryType entryType, string data);
        public void WriteEntry<T>(EntryType entryType, T data) where T : struct;
        public void WriteEntryArray<T>(EntryType entryType, T[] data) where T : struct;
    }
}
