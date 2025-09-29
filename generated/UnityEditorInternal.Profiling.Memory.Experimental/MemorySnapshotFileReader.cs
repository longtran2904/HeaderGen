#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

namespace UnityEditorInternal.Profiling.Memory.Experimental
{
    public class MemorySnapshotFileReader : ISerializationCallbackReceiver
    {
        public MemorySnapshotFileReader(string filePath);
        public MemorySnapshotFileReader();

        public void Dispose();
        public string GetFilePath();
        public void Open(string filePath);
        public void Close();
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
        public void GetDataArray<T>(EntryType entryType, uint entryIndex, uint numEntries, ref T[] dataOut, GetItem<T> getItemFunc);
        public T GetDataSingle<T>(EntryType entryType, GetItem<T> getItemFunc);
        public uint GetNumEntries(EntryType entryType);
    }
}
