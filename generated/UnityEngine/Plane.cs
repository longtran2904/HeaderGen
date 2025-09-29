#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct Plane : IFormattable
    {
        public Plane(Vector3 inNormal, Vector3 inPoint);
        public Plane(Vector3 inNormal, float d);
        public Plane(Vector3 a, Vector3 b, Vector3 c);

        public Vector3 normal { get; set; }
        public float distance { get; set; }
        public Plane flipped { get; }

        public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint);
        public void Set3Points(Vector3 a, Vector3 b, Vector3 c);
        public void Flip();
        public void Translate(Vector3 translation);
        public static Plane Translate(Plane plane, Vector3 translation);
        public Vector3 ClosestPointOnPlane(Vector3 point);
        public float GetDistanceToPoint(Vector3 point);
        public bool GetSide(Vector3 point);
        public bool SameSide(Vector3 inPt0, Vector3 inPt1);
        public bool Raycast(Ray ray, out float enter);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
    }
}
