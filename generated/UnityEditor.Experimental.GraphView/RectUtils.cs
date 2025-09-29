#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public class RectUtils
    {
        public RectUtils();

        public static bool IntersectsSegment(Rect rect, Vector2 p1, Vector2 p2);
        public static Rect Encompass(Rect a, Rect b);
        public static Rect Inflate(Rect a, float left, float top, float right, float bottom);
    }
}
