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
    public struct RectInt : IEquatable<RectInt>, IFormattable
    {
        public RectInt(int xMin, int yMin, int width, int height);
        public RectInt(Vector2Int position, Vector2Int size);

        public int x { get; set; }
        public int y { get; set; }
        public Vector2 center { get; }
        public Vector2Int min { get; set; }
        public Vector2Int max { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int xMin { get; set; }
        public int yMin { get; set; }
        public int xMax { get; set; }
        public int yMax { get; set; }
        public Vector2Int position { get; set; }
        public Vector2Int size { get; set; }
        public PositionEnumerator allPositionsWithin { get; }

        public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition);
        public void ClampToBounds(RectInt bounds);
        public bool Contains(Vector2Int position);
        public bool Overlaps(RectInt other);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public bool Equals(RectInt other);

        public struct PositionEnumerator : IDisposable, IEnumerator, IEnumerator<Vector2Int>
        {
            public PositionEnumerator(Vector2Int min, Vector2Int max);

            public Vector2Int Current { get; }

            public PositionEnumerator GetEnumerator();
            public bool MoveNext();
            public void Reset();
        }
    }
}
