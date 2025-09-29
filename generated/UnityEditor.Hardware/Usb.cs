#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEditor.Hardware
{
    public sealed class Usb
    {
        public Usb();

        public static event OnDevicesChangedHandler DevicesChanged;

        [RequiredByNativeCode]
        public static void OnDevicesChanged(UsbDevice[] devices);

        public delegate void OnDevicesChangedHandler(UsbDevice[] devices);
    }
}
