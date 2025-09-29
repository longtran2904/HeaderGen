#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct BoneWeight1 : IEquatable<BoneWeight1>
    {
        public float weight { get; set; }
        public int boneIndex { get; set; }

        public override bool Equals(object other);
        public bool Equals(BoneWeight1 other);
        public override int GetHashCode();

        public static bool operator ==(BoneWeight1 lhs, BoneWeight1 rhs);
        public static bool operator !=(BoneWeight1 lhs, BoneWeight1 rhs);
    }
}
