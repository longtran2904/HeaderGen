#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public static class CameraEditorUtils
    {
        public static float GameViewAspectRatio { get; }

        public static void HandleFrustum(Camera c, int cameraEditorTargetIndex);
        public static void DrawFrustumGizmo(Camera camera);
        public static bool TryGetSensorGateFrustum(Camera camera, Vector3[] near, Vector3[] far, out float frustumAspect);
        public static bool TryGetFrustum(Camera camera, Vector3[] near, Vector3[] far, out float frustumAspect);
        public static bool IsViewportRectValidToRender(Rect normalizedViewPortRect);
        public static float GetFrustumAspectRatio(Camera camera);
        public static Vector3 PerspectiveClipToWorld(Matrix4x4 clipToWorld, Vector3 viewPositionWS, Vector3 positionCS);
        public static void GetFrustumPlaneAt(Matrix4x4 clipToWorld, Vector3 viewPosition, float distance, Vector3[] points);
    }
}
