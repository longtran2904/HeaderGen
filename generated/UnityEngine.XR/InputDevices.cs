#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    [NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
    [StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
    [UsedByNativeCode]
    public class InputDevices
    {
        public InputDevices();

        public static event Action<InputDevice> deviceConnected;
        public static event Action<InputDevice> deviceDisconnected;
        public static event Action<InputDevice> deviceConfigChanged;

        public static InputDevice GetDeviceAtXRNode(XRNode node);
        public static void GetDevicesAtXRNode(XRNode node, List<InputDevice> inputDevices);
        public static void GetDevices(List<InputDevice> inputDevices);
        [Obsolete("This API has been marked as deprecated and will be removed in future versions. Please use InputDevices.GetDevicesWithCharacteristics instead.")]
        public static void GetDevicesWithRole(InputDeviceRole role, List<InputDevice> inputDevices);
        public static void GetDevicesWithCharacteristics(InputDeviceCharacteristics desiredCharacteristics, List<InputDevice> inputDevices);
    }
}
