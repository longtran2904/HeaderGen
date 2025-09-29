#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEditor.Hardware
{
    [RequiredByNativeCode]
    public struct DevDevice
    {

        public readonly string id;
        public readonly string name;
        public readonly string type;
        public readonly string module;
        public readonly DevDeviceState state;
        public readonly DevDeviceFeatures features;

        public DevDevice(string id, string name, string type, string module, DevDeviceState state, DevDeviceFeatures features);

        public bool isConnected { get; }
        public static DevDevice none { get; }

        public override string ToString();
    }
}
