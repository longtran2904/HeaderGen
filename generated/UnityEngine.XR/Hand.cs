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
    public struct Hand : IEquatable<Hand>
    {
        public bool TryGetRootBone(out Bone boneOut);
        public bool TryGetFingerBones(HandFinger finger, List<Bone> bonesOut);
        public override bool Equals(object obj);
        public bool Equals(Hand other);
        public override int GetHashCode();

        public static bool operator ==(Hand a, Hand b);
        public static bool operator !=(Hand a, Hand b);
    }
}
