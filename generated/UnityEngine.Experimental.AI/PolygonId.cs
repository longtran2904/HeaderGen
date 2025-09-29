#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;

namespace UnityEngine.Experimental.AI
{
    public struct PolygonId : IEquatable<PolygonId>
    {
        public bool IsNull();
        public override int GetHashCode();
        public bool Equals(PolygonId rhs);
        public override bool Equals(object obj);

        public static bool operator ==(PolygonId x, PolygonId y);
        public static bool operator !=(PolygonId x, PolygonId y);
    }
}
