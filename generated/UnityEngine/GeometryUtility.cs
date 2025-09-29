#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    [StaticAccessor("GeometryUtilityScripting", StaticAccessorType.DoubleColon)]
    public sealed class GeometryUtility
    {

        public GeometryUtility();

        public static Plane[] CalculateFrustumPlanes(Camera camera);
        public static Plane[] CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix);
        public static void CalculateFrustumPlanes(Camera camera, Plane[] planes);
        public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes);
        public static Bounds CalculateBounds(Vector3[] positions, Matrix4x4 transform);
        public static bool TryCreatePlaneFromPolygon(Vector3[] vertices, out Plane plane);
        public static bool TestPlanesAABB(Plane[] planes, Bounds bounds);
    }
}
