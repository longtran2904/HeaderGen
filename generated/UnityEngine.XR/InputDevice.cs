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
    [UsedByNativeCode]
    public struct InputDevice : IEquatable<InputDevice>
    {
        public XRInputSubsystem subsystem { get; }
        public bool isValid { get; }
        public string name { get; }
        [Obsolete("This API has been marked as deprecated and will be removed in future versions. Please use InputDevice.characteristics instead.")]
        public InputDeviceRole role { get; }
        public string manufacturer { get; }
        public string serialNumber { get; }
        public InputDeviceCharacteristics characteristics { get; }

        public bool SendHapticImpulse(uint channel, float amplitude, float duration = 1);
        public bool SendHapticBuffer(uint channel, byte[] buffer);
        public bool TryGetHapticCapabilities(out HapticCapabilities capabilities);
        public void StopHaptics();
        public bool TryGetFeatureUsages(List<InputFeatureUsage> featureUsages);
        public bool TryGetFeatureValue(InputFeatureUsage<bool> usage, out bool value);
        public bool TryGetFeatureValue(InputFeatureUsage<uint> usage, out uint value);
        public bool TryGetFeatureValue(InputFeatureUsage<float> usage, out float value);
        public bool TryGetFeatureValue(InputFeatureUsage<Vector2> usage, out Vector2 value);
        public bool TryGetFeatureValue(InputFeatureUsage<Vector3> usage, out Vector3 value);
        public bool TryGetFeatureValue(InputFeatureUsage<Quaternion> usage, out Quaternion value);
        public bool TryGetFeatureValue(InputFeatureUsage<Hand> usage, out Hand value);
        public bool TryGetFeatureValue(InputFeatureUsage<Bone> usage, out Bone value);
        public bool TryGetFeatureValue(InputFeatureUsage<Eyes> usage, out Eyes value);
        public bool TryGetFeatureValue(InputFeatureUsage<byte[]> usage, byte[] value);
        public bool TryGetFeatureValue(InputFeatureUsage<InputTrackingState> usage, out InputTrackingState value);
        public bool TryGetFeatureValue(InputFeatureUsage<bool> usage, DateTime time, out bool value);
        public bool TryGetFeatureValue(InputFeatureUsage<uint> usage, DateTime time, out uint value);
        public bool TryGetFeatureValue(InputFeatureUsage<float> usage, DateTime time, out float value);
        public bool TryGetFeatureValue(InputFeatureUsage<Vector2> usage, DateTime time, out Vector2 value);
        public bool TryGetFeatureValue(InputFeatureUsage<Vector3> usage, DateTime time, out Vector3 value);
        public bool TryGetFeatureValue(InputFeatureUsage<Quaternion> usage, DateTime time, out Quaternion value);
        public bool TryGetFeatureValue(InputFeatureUsage<InputTrackingState> usage, DateTime time, out InputTrackingState value);
        public override bool Equals(object obj);
        public bool Equals(InputDevice other);
        public override int GetHashCode();

        public static bool operator ==(InputDevice a, InputDevice b);
        public static bool operator !=(InputDevice a, InputDevice b);
    }
}
