#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Shaders/PassIdentifier.h")]
    [UsedByNativeCode]
    public readonly struct PassIdentifier : IEquatable<PassIdentifier>
    {

        public uint SubshaderIndex { get; }
        public uint PassIndex { get; }

        public override bool Equals(object o);
        public bool Equals(PassIdentifier rhs);
        public override int GetHashCode();

        public static bool operator ==(PassIdentifier lhs, PassIdentifier rhs);
        public static bool operator !=(PassIdentifier lhs, PassIdentifier rhs);
    }
}
