#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class MathUtils
    {
        public MathUtils();

        public static float GetQuatLength(Quaternion q);
        public static Quaternion GetQuatConjugate(Quaternion q);
        public static Matrix4x4 OrthogonalizeMatrix(Matrix4x4 m);
        public static void QuaternionNormalize(ref Quaternion q);
        public static Quaternion QuaternionFromMatrix(Matrix4x4 m);
        public static Quaternion GetQuatLog(Quaternion q);
        public static Quaternion GetQuatExp(Quaternion q);
        public static Quaternion GetQuatSquad(float t, Quaternion q0, Quaternion q1, Quaternion a0, Quaternion a1);
        public static Quaternion GetSquadIntermediate(Quaternion q0, Quaternion q1, Quaternion q2);
        public static float Ease(float t, float k1, float k2);
        public static Quaternion Slerp(Quaternion p, Quaternion q, float t);
        public static object IntersectRayTriangle(Ray ray, Vector3 v0, Vector3 v1, Vector3 v2, bool bidirectional);
        public static Vector3 ClosestPtSegmentRay(Vector3 p1, Vector3 q1, Ray ray, out float squaredDist, out float s, out Vector3 closestRay);
        public static bool IntersectRaySphere(Ray ray, Vector3 sphereOrigin, float sphereRadius, ref float t, ref Vector3 q);
        public static bool ClosestPtRaySphere(Ray ray, Vector3 sphereOrigin, float sphereRadius, ref float t, ref Vector3 q);
    }
}
