#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Camera))]
    public class CameraEditor : Editor
    {
        public CameraEditor();

        [Obsolete("Preview camera is obsolete, use Overlays to create a Camera preview.")]
        protected Camera previewCamera { get; }
        protected Settings settings { get; }

        public void OnEnable();
        public void OnDestroy();
        public void OnDisable();
        public override void OnInspectorGUI();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("OnOverlayGUI is obsolete, use Overlay to create a preview.")]
        public virtual void OnOverlayGUI(UnityEngine.Object target, SceneView sceneView);
        public virtual void OnSceneGUI();

        public sealed class Settings
        {
            public Settings(SerializedObject so);

            public static IEnumerable<string> ApertureFormatNames { get; }
            public static IEnumerable<Vector2> ApertureFormatValues { get; }
            public SerializedProperty clearFlags { get; }
            public SerializedProperty backgroundColor { get; }
            public SerializedProperty normalizedViewPortRect { get; }
            public SerializedProperty sensorSize { get; }
            public SerializedProperty lensShift { get; }
            public SerializedProperty focalLength { get; }
            public SerializedProperty gateFit { get; }
            public SerializedProperty verticalFOV { get; }
            public SerializedProperty orthographic { get; }
            public SerializedProperty orthographicSize { get; }
            public SerializedProperty depth { get; }
            public SerializedProperty cullingMask { get; }
            public SerializedProperty renderingPath { get; }
            public SerializedProperty occlusionCulling { get; }
            public SerializedProperty targetTexture { get; }
            public SerializedProperty HDR { get; }
            public SerializedProperty allowMSAA { get; }
            public SerializedProperty allowDynamicResolution { get; }
            public SerializedProperty stereoConvergence { get; }
            public SerializedProperty stereoSeparation { get; }
            public SerializedProperty nearClippingPlane { get; }
            public SerializedProperty farClippingPlane { get; }
            public SerializedProperty fovAxisMode { get; }
            public SerializedProperty targetDisplay { get; }
            public SerializedProperty targetEye { get; }

            public void OnEnable();
            public void Update();
            public void ApplyModifiedProperties();
            public void DrawClearFlags();
            public void DrawBackgroundColor();
            public void DrawCullingMask();
            public void DrawProjection();
            public void DrawClippingPlanes();
            public void DrawNormalizedViewPort();
            public void DrawDepth();
            public void DrawRenderingPath();
            public void DrawTargetTexture(bool deferred);
            public void DrawOcclusionCulling();
            public void DrawHDR();
            public void DrawMSAA();
            public void DrawDynamicResolution();
            public void DrawVR();
            public void DrawMultiDisplay();
            public void DrawTargetEye();
            public static void DrawCameraWarnings(Camera camera);
        }
    }
}
