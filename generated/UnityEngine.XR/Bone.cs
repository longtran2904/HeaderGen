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
    [NativeHeader("Modules/XR/XRPrefix.h")]
    [NativeHeader("XRScriptingClasses.h")]
    [NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
    [RequiredByNativeCode]
    [StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
    public struct Bone : IEquatable<Bone>
    {

        public bool TryGetPosition(out Vector3 position);
        public bool TryGetRotation(out Quaternion rotation);
        public bool TryGetParentBone(out Bone parentBone);
        public bool TryGetChildBones(List<Bone> childBones);
        public override bool Equals(object obj);
        public bool Equals(Bone other);
        public override int GetHashCode();

        public static bool operator ==(Bone a, Bone b);
        public static bool operator !=(Bone a, Bone b);
    }
}
