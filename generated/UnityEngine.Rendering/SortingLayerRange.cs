#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct SortingLayerRange : IEquatable<SortingLayerRange>
    {

        public SortingLayerRange(short lowerBound, short upperBound);

        public short lowerBound { get; set; }
        public short upperBound { get; set; }
        public static SortingLayerRange all { get; }

        public bool Equals(SortingLayerRange other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator !=(SortingLayerRange lhs, SortingLayerRange rhs);
        public static bool operator ==(SortingLayerRange lhs, SortingLayerRange rhs);
    }
}
