#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    [NativeHeader("Modules/XR/XRPrefix.h")]
    [NativeHeader("XRScriptingClasses.h")]
    [NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
    [RequiredByNativeCode]
    [StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
    public struct Eyes : IEquatable<Eyes>
    {

        public bool TryGetLeftEyePosition(out Vector3 position);
        public bool TryGetRightEyePosition(out Vector3 position);
        public bool TryGetLeftEyeRotation(out Quaternion rotation);
        public bool TryGetRightEyeRotation(out Quaternion rotation);
        public bool TryGetFixationPoint(out Vector3 fixationPoint);
        public bool TryGetLeftEyeOpenAmount(out float openAmount);
        public bool TryGetRightEyeOpenAmount(out float openAmount);
        public override bool Equals(object obj);
        public bool Equals(Eyes other);
        public override int GetHashCode();

        public static bool operator ==(Eyes a, Eyes b);
        public static bool operator !=(Eyes a, Eyes b);
    }
}
