#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Jobs;

namespace Unity.IO.LowLevel.Unsafe
{
    public readonly struct FileHandle
    {

        public FileStatus Status { get; }
        public JobHandle JobHandle { get; }

        public bool IsValid();
        public JobHandle Close(JobHandle dependency = null);
    }
}
