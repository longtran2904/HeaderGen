#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

namespace UnityEngine.VFX
{
    public struct VFXOutputEventArgs
    {

        public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute);

        public int nameId { get; }
        public VFXEventAttribute eventAttribute { get; }
    }
}
