#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    [NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
    [RequiredByNativeCode]
    public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
    {

        public string name { get; }
        public Type type { get; }

        public override bool Equals(object obj);
        public bool Equals(InputFeatureUsage other);
        public override int GetHashCode();
        public InputFeatureUsage<T> As<T>();

        public static bool operator ==(InputFeatureUsage a, InputFeatureUsage b);
        public static bool operator !=(InputFeatureUsage a, InputFeatureUsage b);
    }
}
