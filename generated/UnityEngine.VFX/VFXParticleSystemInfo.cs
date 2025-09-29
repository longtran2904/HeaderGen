#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [NativeHeader("Modules/VFX/Public/VFXSystem.h")]
    [UsedByNativeCode]
    public struct VFXParticleSystemInfo
    {
        public uint aliveCount;
        public uint capacity;
        public bool sleeping;
        public Bounds bounds;

        public VFXParticleSystemInfo(uint aliveCount, uint capacity, bool sleeping, Bounds bounds);
    }
}
