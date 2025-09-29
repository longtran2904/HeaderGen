#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
    [StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
    public sealed class Gizmos
    {

        public Gizmos();

        public static Color color { get; set; }
        public static Matrix4x4 matrix { get; set; }
        public static Texture exposure { get; set; }
        public static float probeSize { get; }

        [NativeThrows]
        public static void DrawLine(Vector3 from, Vector3 to);
        [NativeThrows]
        public static void DrawWireSphere(Vector3 center, float radius);
        [NativeThrows]
        public static void DrawSphere(Vector3 center, float radius);
        [NativeThrows]
        public static void DrawWireCube(Vector3 center, Vector3 size);
        [NativeThrows]
        public static void DrawCube(Vector3 center, Vector3 size);
        [NativeThrows]
        public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale);
        [NativeThrows]
        public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale);
        [NativeThrows]
        public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling);
        [NativeThrows]
        public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] Color tint);
        [NativeThrows]
        public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat);
        public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect);
        public static void DrawRay(Ray r);
        public static void DrawRay(Vector3 from, Vector3 direction);
        [ExcludeFromDocs]
        public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation);
        [ExcludeFromDocs]
        public static void DrawMesh(Mesh mesh, Vector3 position);
        [ExcludeFromDocs]
        public static void DrawMesh(Mesh mesh);
        public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale);
        [ExcludeFromDocs]
        public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation);
        [ExcludeFromDocs]
        public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position);
        [ExcludeFromDocs]
        public static void DrawMesh(Mesh mesh, int submeshIndex);
        [ExcludeFromDocs]
        public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation);
        [ExcludeFromDocs]
        public static void DrawWireMesh(Mesh mesh, Vector3 position);
        [ExcludeFromDocs]
        public static void DrawWireMesh(Mesh mesh);
        public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale);
        [ExcludeFromDocs]
        public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation);
        [ExcludeFromDocs]
        public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position);
        [ExcludeFromDocs]
        public static void DrawWireMesh(Mesh mesh, int submeshIndex);
        [ExcludeFromDocs]
        public static void DrawIcon(Vector3 center, string name);
        [ExcludeFromDocs]
        public static void DrawGUITexture(Rect screenRect, Texture texture);
        public static void DrawGUITexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat);
        [ExcludeFromDocs]
        public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder);
    }
}
