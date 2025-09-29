#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Jobs;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
    [NativeHeader("Runtime/File/AsyncReadManagerManagedApi.h")]
    public static class AsyncReadManager
    {
        public static ReadHandle Read(string filename, ReadCommand* readCmds, uint readCmdCount, string assetName = "", ulong typeID = 0, AssetLoadingSubsystem subsystem = AssetLoadingSubsystem.Scripts);
        public static ReadHandle GetFileInfo(string filename, FileInfoResult* result);
        public static ReadHandle ReadDeferred(in FileHandle fileHandle, ReadCommandArray* readCmdArray, JobHandle dependency);
        public static ReadHandle Read(in FileHandle fileHandle, ReadCommandArray readCmdArray);
        public static FileHandle OpenFileAsync(string fileName);
        [FreeFunction("AsyncReadManagerManaged::ScheduleCloseCachedFileRequest", IsThreadSafe = True)]
        [ThreadAndSerializationSafe]
        public static JobHandle CloseCachedFileAsync(string fileName, JobHandle dependency = null);
    }
}
