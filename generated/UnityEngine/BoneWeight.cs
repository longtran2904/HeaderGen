#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct BoneWeight : IEquatable<BoneWeight>
    {

        public float weight0 { get; set; }
        public float weight1 { get; set; }
        public float weight2 { get; set; }
        public float weight3 { get; set; }
        public int boneIndex0 { get; set; }
        public int boneIndex1 { get; set; }
        public int boneIndex2 { get; set; }
        public int boneIndex3 { get; set; }

        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(BoneWeight other);

        public static bool operator ==(BoneWeight lhs, BoneWeight rhs);
        public static bool operator !=(BoneWeight lhs, BoneWeight rhs);
    }
}
