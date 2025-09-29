#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct DepthState : IEquatable<DepthState>
    {

        public DepthState(bool writeEnabled = True, CompareFunction compareFunction = CompareFunction.Less);

        public static DepthState defaultValue { get; }
        public bool writeEnabled { get; set; }
        public CompareFunction compareFunction { get; set; }

        public bool Equals(DepthState other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(DepthState left, DepthState right);
        public static bool operator !=(DepthState left, DepthState right);
    }
}
