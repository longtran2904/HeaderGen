#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
    [NativeHeader("Runtime/Math/Rect.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Rect : IEquatable<Rect>, IFormattable
    {

        public Rect(float x, float y, float width, float height);
        public Rect(Vector2 position, Vector2 size);
        public Rect(Rect source);

        public static Rect zero { get; }
        public float x { get; set; }
        public float y { get; set; }
        public Vector2 position { get; set; }
        public Vector2 center { get; set; }
        public Vector2 min { get; set; }
        public Vector2 max { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public Vector2 size { get; set; }
        public float xMin { get; set; }
        public float yMin { get; set; }
        public float xMax { get; set; }
        public float yMax { get; set; }
        [Obsolete("use xMin")]
        public float left { get; }
        [Obsolete("use xMax")]
        public float right { get; }
        [Obsolete("use yMin")]
        public float top { get; }
        [Obsolete("use yMax")]
        public float bottom { get; }

        public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
        public void Set(float x, float y, float width, float height);
        public bool Contains(Vector2 point);
        public bool Contains(Vector3 point);
        public bool Contains(Vector3 point, bool allowInverse);
        public bool Overlaps(Rect other);
        public bool Overlaps(Rect other, bool allowInverse);
        public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates);
        public static Vector2 PointToNormalized(Rect rectangle, Vector2 point);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Rect other);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static bool operator !=(Rect lhs, Rect rhs);
        public static bool operator ==(Rect lhs, Rect rhs);
    }
}
