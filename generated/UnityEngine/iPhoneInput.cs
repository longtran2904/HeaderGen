#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iPhoneInput class is deprecated. Please use Input instead (UnityUpgradable) -> Input", True)]
    public class iPhoneInput
    {

        public iPhoneInput();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("orientation property is deprecated. Please use Input.deviceOrientation instead (UnityUpgradable) -> Input.deviceOrientation", True)]
        public static iPhoneOrientation orientation { get; }
        public static iPhoneAccelerationEvent[] accelerationEvents { get; }
        public static iPhoneTouch[] touches { get; }
        public static int touchCount { get; }
        public static bool multiTouchEnabled { get; set; }
        public static int accelerationEventCount { get; }
        public static Vector3 acceleration { get; }

        public static iPhoneTouch GetTouch(int index);
        public static iPhoneAccelerationEvent GetAccelerationEvent(int index);
    }
}
