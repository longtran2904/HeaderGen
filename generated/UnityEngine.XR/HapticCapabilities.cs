#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    public struct HapticCapabilities : IEquatable<HapticCapabilities>
    {
        public uint numChannels { get; }
        public bool supportsImpulse { get; }
        public bool supportsBuffer { get; }
        public uint bufferFrequencyHz { get; }
        public uint bufferMaxSize { get; }
        public uint bufferOptimalSize { get; }

        public override bool Equals(object obj);
        public bool Equals(HapticCapabilities other);
        public override int GetHashCode();

        public static bool operator ==(HapticCapabilities a, HapticCapabilities b);
        public static bool operator !=(HapticCapabilities a, HapticCapabilities b);
    }
}
