#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct ShadowSplitData : IEquatable<ShadowSplitData>
    {

        public static readonly int maximumCullingPlaneCount;

        public int cullingPlaneCount { get; set; }
        public Vector4 cullingSphere { get; set; }
        public float shadowCascadeBlendCullingFactor { get; set; }

        public Plane GetCullingPlane(int index);
        public void SetCullingPlane(int index, Plane plane);
        public bool Equals(ShadowSplitData other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(ShadowSplitData left, ShadowSplitData right);
        public static bool operator !=(ShadowSplitData left, ShadowSplitData right);
    }
}
