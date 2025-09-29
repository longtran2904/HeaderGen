#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using Unity.Jobs;

namespace Unity.IO.LowLevel.Unsafe
{
    public struct ReadHandle : IDisposable
    {
        public JobHandle JobHandle { get; }
        public ReadStatus Status { get; }
        public long ReadCount { get; }

        public bool IsValid();
        public void Dispose();
        public void Cancel();
        public long GetBytesRead();
        public long GetBytesRead(uint readCommandIndex);
        public ulong* GetBytesReadArray();
    }
}
