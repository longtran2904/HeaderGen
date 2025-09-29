#region UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/InputBindings.h")]
    public class Input
    {

        public Input();

        public static bool simulateMouseWithTouches { get; set; }
        [NativeThrows]
        public static bool anyKey { get; }
        [NativeThrows]
        public static bool anyKeyDown { get; }
        [NativeThrows]
        public static string inputString { get; }
        [NativeThrows]
        public static Vector3 mousePosition { get; }
        [NativeThrows]
        public static Vector2 mouseScrollDelta { get; }
        public static IMECompositionMode imeCompositionMode { get; set; }
        public static string compositionString { get; }
        public static bool imeIsSelected { get; }
        public static Vector2 compositionCursorPos { get; set; }
        [Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
        public static bool eatKeyPressOnTextFieldFocus { get; set; }
        public static bool mousePresent { get; }
        public static int touchCount { get; }
        public static bool touchPressureSupported { get; }
        public static bool stylusTouchSupported { get; }
        public static bool touchSupported { get; }
        public static bool multiTouchEnabled { get; set; }
        [Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
        public static bool isGyroAvailable { get; }
        public static DeviceOrientation deviceOrientation { get; }
        public static Vector3 acceleration { get; }
        public static bool compensateSensors { get; set; }
        public static int accelerationEventCount { get; }
        public static bool backButtonLeavesApp { get; set; }
        public static LocationService location { get; }
        public static Compass compass { get; }
        public static Gyroscope gyro { get; }
        public static Touch[] touches { get; }
        public static AccelerationEvent[] accelerationEvents { get; }

        [NativeThrows]
        public static float GetAxis(string axisName);
        [NativeThrows]
        public static float GetAxisRaw(string axisName);
        [NativeThrows]
        public static bool GetButton(string buttonName);
        [NativeThrows]
        public static bool GetButtonDown(string buttonName);
        [NativeThrows]
        public static bool GetButtonUp(string buttonName);
        [NativeThrows]
        public static bool GetMouseButton(int button);
        [NativeThrows]
        public static bool GetMouseButtonDown(int button);
        [NativeThrows]
        public static bool GetMouseButtonUp(int button);
        [FreeFunction("ResetInput")]
        public static void ResetInputAxes();
        public static bool IsJoystickPreconfigured(string joystickName);
        [NativeThrows]
        public static string[] GetJoystickNames();
        [NativeThrows]
        public static Touch GetTouch(int index);
        [NativeThrows]
        public static AccelerationEvent GetAccelerationEvent(int index);
        public static bool GetKey(KeyCode key);
        public static bool GetKey(string name);
        public static bool GetKeyUp(KeyCode key);
        public static bool GetKeyUp(string name);
        public static bool GetKeyDown(KeyCode key);
        public static bool GetKeyDown(string name);
    }
}
