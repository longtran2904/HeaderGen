#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
    {

        public BoundsInt(int xMin, int yMin, int zMin, int sizeX, int sizeY, int sizeZ);
        public BoundsInt(Vector3Int position, Vector3Int size);

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Vector3 center { get; }
        public Vector3Int min { get; set; }
        public Vector3Int max { get; set; }
        public int xMin { get; set; }
        public int yMin { get; set; }
        public int zMin { get; set; }
        public int xMax { get; set; }
        public int yMax { get; set; }
        public int zMax { get; set; }
        public Vector3Int position { get; set; }
        public Vector3Int size { get; set; }
        public PositionEnumerator allPositionsWithin { get; }

        public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition);
        public void ClampToBounds(BoundsInt bounds);
        public bool Contains(Vector3Int position);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public override bool Equals(object other);
        public bool Equals(BoundsInt other);
        public override int GetHashCode();

        public static bool operator ==(BoundsInt lhs, BoundsInt rhs);
        public static bool operator !=(BoundsInt lhs, BoundsInt rhs);
        public struct PositionEnumerator : IDisposable, IEnumerator, IEnumerator<Vector3Int>
        {

            public PositionEnumerator(Vector3Int min, Vector3Int max);

            public Vector3Int Current { get; }

            public PositionEnumerator GetEnumerator();
            public bool MoveNext();
            public void Reset();
        }
    }
}
