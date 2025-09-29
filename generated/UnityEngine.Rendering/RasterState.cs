#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct RasterState : IEquatable<RasterState>
    {
        public static readonly RasterState defaultValue;

        public RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = True);

        public CullMode cullingMode { get; set; }
        public bool depthClip { get; set; }
        public bool conservative { get; set; }
        public int offsetUnits { get; set; }
        public float offsetFactor { get; set; }

        public bool Equals(RasterState other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(RasterState left, RasterState right);
        public static bool operator !=(RasterState left, RasterState right);
    }
}
