#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEditor.Hardware
{
    [RequiredByNativeCode(GenerateProxy = True)]
    public struct UsbDevice
    {
        public readonly int vendorId;
        public readonly int productId;
        public readonly int revision;
        public readonly string udid;
        public readonly string name;

        public override string ToString();
    }
}
