#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Handles/Handles.bindings.h")]
    public sealed class Handles
    {

        public Handles();

        [NativeProperty("handles::g_HandleLighting", True, TargetType.Field)]
        public static bool lighting { get; set; }
        [NativeProperty("handles::g_HandleColor", True, TargetType.Field)]
        public static Color color { get; set; }
        [NativeProperty("handles::g_HandleZTest", True, TargetType.Field)]
        public static CompareFunction zTest { get; set; }
        public static Matrix4x4 matrix { get; set; }
        [NativeProperty("handles::g_HandleInverseMatrix", True, TargetType.Field)]
        public static Matrix4x4 inverseMatrix { get; }
        public static Color xAxisColor { get; }
        public static Color yAxisColor { get; }
        public static Color zAxisColor { get; }
        public static Color centerColor { get; }
        public static Color selectedColor { get; }
        public static Color preselectionColor { get; }
        public static Color secondaryColor { get; }
        public static Color UIColliderHandleColor { get; }
        public static float lineThickness { get; }
        public Camera currentCamera { get; set; }

        public static void DrawPolyLine(params Vector3[] points);
        [ExcludeFromDocs]
        public static void DrawLine(Vector3 p1, Vector3 p2);
        public static void DrawLine(Vector3 p1, Vector3 p2, [DefaultValue("0.0f")] float thickness);
        public static void DrawLines(Vector3[] lineSegments);
        public static void DrawLines(Vector3[] points, int[] segmentIndices);
        public static void DrawDottedLine(Vector3 p1, Vector3 p2, float screenSpaceSize);
        public static void DrawDottedLines(Vector3[] lineSegments, float screenSpaceSize);
        public static void DrawDottedLines(Vector3[] points, int[] segmentIndices, float screenSpaceSize);
        public static void DrawWireCube(Vector3 center, Vector3 size);
        public static bool ShouldRenderGizmos();
        public static void DrawGizmos(Camera camera);
        public static Quaternion Disc(int id, Quaternion rotation, Vector3 position, Vector3 axis, float size, bool cutoffPlane, float snap);
        public static Quaternion FreeRotateHandle(int id, Quaternion rotation, Vector3 position, float size);
        public static Vector3 Slider(Vector3 position, Vector3 direction);
        public static Vector3 Slider(Vector3 position, Vector3 direction, float size, CapFunction capFunction, float snap);
        public static Vector3 Slider(int controlID, Vector3 position, Vector3 direction, float size, CapFunction capFunction, float snap);
        public static Vector3 Slider(int controlID, Vector3 position, Vector3 offset, Vector3 direction, float size, CapFunction capFunction, float snap);
        public static Vector3 FreeMoveHandle(Vector3 position, Quaternion rotation, float size, Vector3 snap, CapFunction capFunction);
        public static Vector3 FreeMoveHandle(int controlID, Vector3 position, Quaternion rotation, float size, Vector3 snap, CapFunction capFunction);
        public static float ScaleValueHandle(float value, Vector3 position, Quaternion rotation, float size, CapFunction capFunction, float snap);
        public static float ScaleValueHandle(int controlID, float value, Vector3 position, Quaternion rotation, float size, CapFunction capFunction, float snap);
        public static bool Button(Vector3 position, Quaternion direction, float size, float pickSize, CapFunction capFunction);
        public static void CubeHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void SphereHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void ConeHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void CylinderHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void RectangleHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void DotHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void CircleHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void ArrowHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static void DrawSelectionFrame(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static Vector3 PositionHandle(Vector3 position, Quaternion rotation);
        public static Quaternion RotationHandle(Quaternion rotation, Vector3 position);
        public static Vector3 ScaleHandle(Vector3 scale, Vector3 position, Quaternion rotation);
        public static Vector3 ScaleHandle(Vector3 scale, Vector3 position, Quaternion rotation, float size);
        public static float RadiusHandle(Quaternion rotation, Vector3 position, float radius, bool handlesOnly);
        public static float RadiusHandle(Quaternion rotation, Vector3 position, float radius);
        public static Vector3 Slider2D(int id, Vector3 handlePos, Vector3 offset, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap);
        public static Vector3 Slider2D(int id, Vector3 handlePos, Vector3 offset, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap, [DefaultValue("false")] bool drawHelper);
        public static Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap);
        public static Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap, [DefaultValue("false")] bool drawHelper);
        public static Vector3 Slider2D(int id, Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap);
        public static Vector3 Slider2D(int id, Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap, [DefaultValue("false")] bool drawHelper);
        public static Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, float snap);
        public static Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, float snap, [DefaultValue("false")] bool drawHelper);
        public static Quaternion FreeRotateHandle(Quaternion rotation, Vector3 position, float size);
        public static float ScaleSlider(float scale, Vector3 position, Vector3 direction, Quaternion rotation, float size, float snap);
        public static Quaternion Disc(Quaternion rotation, Vector3 position, Vector3 axis, float size, bool cutoffPlane, float snap);
        public static float SnapValue(float value, float snap);
        public static Vector2 SnapValue(Vector2 value, Vector2 snap);
        public static Vector3 SnapValue(Vector3 value, Vector3 snap);
        public static void SnapToGrid(Transform[] transforms, SnapAxis axis = SnapAxis.All);
        public static void SelectionFrame(int controlID, Vector3 position, Quaternion rotation, float size);
        public static void DrawAAPolyLine(params Vector3[] points);
        public static void DrawAAPolyLine(float width, params Vector3[] points);
        public static void DrawAAPolyLine(Texture2D lineTex, params Vector3[] points);
        public static void DrawAAPolyLine(float width, int actualNumberOfPoints, params Vector3[] points);
        public static void DrawAAPolyLine(Texture2D lineTex, float width, params Vector3[] points);
        public static void DrawAAConvexPolygon(params Vector3[] points);
        public static void DrawBezier(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, Color color, Texture2D texture, float width);
        [ExcludeFromDocs]
        public static void DrawWireDisc(Vector3 center, Vector3 normal, float radius);
        public static void DrawWireDisc(Vector3 center, Vector3 normal, float radius, [DefaultValue("0.0f")] float thickness);
        [ExcludeFromDocs]
        public static void DrawWireArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
        public static void DrawWireArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius, [DefaultValue("0.0f")] float thickness);
        public static void DrawSolidRectangleWithOutline(Rect rectangle, Color faceColor, Color outlineColor);
        public static void DrawSolidRectangleWithOutline(Vector3[] verts, Color faceColor, Color outlineColor);
        public static void DrawSolidDisc(Vector3 center, Vector3 normal, float radius);
        public static void DrawSolidArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
        public static void Label(Vector3 position, string text);
        public static void Label(Vector3 position, Texture image);
        public static void Label(Vector3 position, GUIContent content);
        public static void Label(Vector3 position, string text, GUIStyle style);
        public static void Label(Vector3 position, GUIContent content, GUIStyle style);
        public static Vector2 GetMainGameViewSize();
        public static void ClearCamera(Rect position, Camera camera);
        public static void DrawCamera(Rect position, Camera camera);
        public static void DrawCamera(Rect position, Camera camera, [DefaultValue("UnityEditor.DrawCameraMode.Normal")] DrawCameraMode drawMode);
        public static void DrawCamera(Rect position, Camera camera, [DefaultValue("UnityEditor.DrawCameraMode.Normal")] DrawCameraMode drawMode, bool drawGizmos);
        public static void SetCamera(Camera camera);
        public static void SetCamera(Rect position, Camera camera);
        public static void BeginGUI();
        [Obsolete("Please use BeginGUI() with GUILayout.BeginArea(position) / GUILayout.EndArea()")]
        public static void BeginGUI(Rect position);
        public static void EndGUI();
        public static Vector3[] MakeBezierPoints(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, int division);
        public static void DrawTexture3DSDF(Texture texture, [DefaultValue("1.0f")] float stepScale = 1, [DefaultValue("0.0f")] float surfaceOffset = 0, [DefaultValue("null")] Gradient customColorRamp = null);
        public static void DrawTexture3DSlice(Texture texture, Vector3 slicePositions, [DefaultValue("FilterMode.Bilinear")] FilterMode filterMode = FilterMode.Bilinear, [DefaultValue("false")] bool useColorRamp = False, [DefaultValue("null")] Gradient customColorRamp = null);
        public static void DrawTexture3DVolume(Texture texture, [DefaultValue("1.0f")] float opacity = 1, [DefaultValue("1.0f")] float qualityModifier = 1, [DefaultValue("FilterMode.Bilinear")] FilterMode filterMode = FilterMode.Bilinear, [DefaultValue("false")] bool useColorRamp = False, [DefaultValue("null")] Gradient customColorRamp = null);
        public static Vector3 DoPositionHandle(Vector3 position, Quaternion rotation);
        public static Quaternion DoRotationHandle(Quaternion rotation, Vector3 position);
        public static Vector3 DoScaleHandle(Vector3 scale, Vector3 position, Quaternion rotation, float size);
        public static void TransformHandle(ref Vector3 position, ref Quaternion rotation, ref Vector3 scale);
        public static void TransformHandle(ref Vector3 position, Quaternion rotation, ref Vector3 scale);
        public static void TransformHandle(Vector3 position, ref Quaternion rotation, ref Vector3 scale);
        public static void TransformHandle(ref Vector3 position, ref Quaternion rotation, ref float uniformScale);
        public static void TransformHandle(ref Vector3 position, Quaternion rotation, ref float uniformScale);
        public static void TransformHandle(Vector3 position, ref Quaternion rotation, ref float uniformScale);
        public static void TransformHandle(ref Vector3 position, ref Quaternion rotation);
        public struct DrawingScope : IDisposable
        {

            public DrawingScope(Color color);
            public DrawingScope(Matrix4x4 matrix);
            public DrawingScope(Color color, Matrix4x4 matrix);

            public Color originalColor { get; }
            public Matrix4x4 originalMatrix { get; }

            public void Dispose();
        }
        public delegate void CapFunction(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public delegate float SizeFunction(Vector3 position);
    }
}
