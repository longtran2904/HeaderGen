#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Hardware
{
    [NativeHeader("Editor/Src/Devices/DevDevice.h")]
    public sealed class DevDeviceList
    {
        public DevDeviceList();

        public static event OnChangedHandler Changed;

        public static void OnChanged();
        public static bool FindDevice(string deviceId, out DevDevice device);
        [FreeFunction("GetDeviceList")]
        public static DevDevice[] GetDevices();

        public delegate void OnChangedHandler();
    }
}
