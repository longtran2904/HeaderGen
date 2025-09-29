#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/HandleUtility.bindings.h")]
    [StaticAccessor("HandleUtilityBindings", StaticAccessorType.DoubleColon)]
    public sealed class HandleUtility
    {
        public HandleUtility();

        public static float acceleration { get; }
        public static float niceMouseDelta { get; }
        public static float niceMouseDeltaZoom { get; }
        public static int nearestControl { get; set; }
        public static Material handleMaterial { get; }

        public static event PickGameObjectCallback pickGameObjectCustomPasses;
        public static event PlaceObjectDelegate placeObjectCustomPasses;

        public static float DistancePointBezier(Vector3 point, Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent);
        public static float CalcLineTranslation(Vector2 src, Vector2 dest, Vector3 srcPosition, Vector3 constraintDir);
        public static float PointOnLineParameter(Vector3 point, Vector3 linePoint, Vector3 lineDirection);
        public static Vector3 ProjectPointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd);
        public static float DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd);
        public static float DistanceToLine(Vector3 p1, Vector3 p2);
        public static float DistanceToCircle(Vector3 position, float radius);
        public static float DistanceToCircle(CameraProjectionCache projection, Vector3 position, float radius);
        public static float DistanceToCone(Vector3 position, Quaternion rotation, float size);
        public static float DistanceToCube(Vector3 position, Quaternion rotation, float size);
        public static float DistanceToRectangle(Vector3 position, Quaternion rotation, float size);
        public static float DistancePointToLine(Vector2 p, Vector2 a, Vector2 b);
        public static float DistancePointToLineSegment(Vector2 p, Vector2 a, Vector2 b);
        public static float DistanceToDisc(Vector3 center, Vector3 normal, float radius);
        public static Vector3 ClosestPointToDisc(Vector3 center, Vector3 normal, float radius);
        public static float DistanceToArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
        public static Vector3 ClosestPointToArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
        public static float DistanceToPolyLine(params Vector3[] points);
        public static Vector3 ClosestPointToPolyLine(params Vector3[] vertices);
        public static void AddControl(int controlId, float distance);
        public static void AddDefaultControl(int controlId);
        public static float GetHandleSize(Vector3 position);
        public static Vector2 WorldToGUIPoint(Vector3 world);
        public static Vector3 WorldToGUIPointWithDepth(Vector3 world);
        public static Vector3 WorldToGUIPointWithDepth(Camera camera, Vector3 world);
        public static Vector2 GUIPointToScreenPixelCoordinate(Vector2 guiPoint);
        public static Ray GUIPointToWorldRay(Vector2 position);
        public static Rect WorldPointToSizedRect(Vector3 position, GUIContent content, GUIStyle style);
        public static GameObject[] PickRectObjects(Rect rect);
        public static GameObject[] PickRectObjects(Rect rect, bool selectPrefabRootsOnly);
        public static bool FindNearestVertex(Vector2 guiPoint, out Vector3 vertex);
        public static bool FindNearestVertex(Vector2 guiPoint, Transform[] objectsToSearch, out Vector3 vertex);
        public static bool FindNearestVertex(Vector2 guiPoint, Transform[] objectsToSearch, Transform[] objectsToIgnore, out Vector3 vertex);
        public static GameObject PickGameObject(Vector2 position, out int materialIndex);
        public static GameObject PickGameObject(Vector2 position, GameObject[] ignore, out int materialIndex);
        public static GameObject PickGameObject(Vector2 position, GameObject[] ignore, GameObject[] selection, out int materialIndex);
        public static GameObject PickGameObject(Vector2 position, bool selectPrefabRoot);
        public static GameObject PickGameObject(Vector2 position, bool selectPrefabRoot, GameObject[] ignore);
        public static GameObject PickGameObject(Vector2 position, bool selectPrefabRoot, GameObject[] ignore, GameObject[] filter);
        public static GameObject PickGameObject(Vector2 position, bool selectPrefabRoot, GameObject[] ignore, GameObject[] filter, out int materialIndex);
        public static void PushCamera(Camera camera);
        public static void PopCamera(Camera camera);
        public static object RaySnap(Ray ray);
        public static bool PlaceObject(Vector2 guiPosition, out Vector3 position, out Vector3 normal);
        public static void Repaint();

        public delegate GameObject PickGameObjectCallback(Camera cam, int layers, Vector2 position, GameObject[] ignore, GameObject[] filter, out int materialIndex);
        public delegate bool PlaceObjectDelegate(Vector2 guiPosition, out Vector3 position, out Vector3 normal);
    }
}
