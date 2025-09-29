#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeType("Runtime/Graphics/RefreshRate.h")]
    public struct RefreshRate : IEquatable<RefreshRate>
    {
        [RequiredMember]
        public uint numerator;
        [RequiredMember]
        public uint denominator;

        public double value { get; }

        public bool Equals(RefreshRate other);
    }
}
