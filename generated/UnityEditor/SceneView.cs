#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.ComponentModel;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [EditorWindowTitle(title = "Scene", useTypeNameAsIconName = True)]
    public class SceneView : SearchableEditorWindow, IHasCustomMenu, ISupportsOverlays
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("m_SceneLighting has been deprecated. Use sceneLighting instead (UnityUpgradable) -> UnityEditor.SceneView.sceneLighting", True)]
        public bool m_SceneLighting;
        [Obsolete("m_AudioPlay has been deprecated. Use audioPlay instead (UnityUpgradable) -> audioPlay", True)]
        public bool m_AudioPlay;
        [Obsolete("Use cameraMode instead", False)]
        public DrawCameraMode m_RenderMode;
        [Obsolete("m_ValidateTrueMetals has been deprecated. Use validateTrueMetals instead (UnityUpgradable) -> validateTrueMetals", True)]
        public bool m_ValidateTrueMetals;
        public static Action<SceneView, SceneView> lastActiveSceneViewChanged;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("onSceneGUIDelegate has been deprecated. Use duringSceneGui instead.")]
        public static OnSceneFunc onSceneGUIDelegate;

        public SceneView();

        public static SceneView lastActiveSceneView { get; }
        public static SceneView currentDrawingSceneView { get; }
        public static Color selectedOutlineColor { get; }
        public bool isUsingSceneFiltering { get; }
        public bool drawGizmos { get; set; }
        protected internal Scene customScene { get; set; }
        protected internal Transform customParentForDraggedObjects { get; set; }
        public bool sceneLighting { get; set; }
        public bool in2DMode { get; set; }
        public bool isRotationLocked { get; set; }
        public bool audioPlay { get; set; }
        [Obsolete("Use cameraMode instead", False)]
        public DrawCameraMode renderMode { get; set; }
        public CameraMode cameraMode { get; set; }
        public bool validateTrueMetals { get; set; }
        public SceneViewState sceneViewState { get; set; }
        public bool showGrid { get; set; }
        public CameraSettings cameraSettings { get; set; }
        public Quaternion lastSceneViewRotation { get; set; }
        public float cameraDistance { get; }
        public static ArrayList sceneViews { get; }
        public Camera camera { get; }
        public Vector3 pivot { get; set; }
        public Quaternion rotation { get; set; }
        public float size { get; set; }
        public bool orthographic { get; set; }

        public event Func<CameraMode, bool> onValidateCameraMode;
        public event Action<CameraMode> onCameraModeChanged;
        public event Action<bool> gridVisibilityChanged;
        public static event Action<SceneView> beforeSceneGui;
        public static event Action<SceneView> duringSceneGui;

        public void ResetCameraSettings();
        public void SetSceneViewShaderReplace(Shader shader, string replaceString);
        public static bool FrameLastActiveSceneView();
        public static bool FrameLastActiveSceneViewWithLock();
        public static Camera[] GetAllSceneCameras();
        public static void RepaintAll();
        public override void OnEnable();
        protected virtual bool SupportsStageHandling();
        public override void OnDisable();
        public void OnDestroy();
        public virtual void AddItemsToMenu(GenericMenu menu);
        public bool IsCameraDrawModeSupported(CameraMode mode);
        public bool IsCameraDrawModeEnabled(CameraMode mode);
        [Obsolete("OnGUI has been deprecated. Use OnSceneGUI instead.")]
        protected virtual void OnGUI();
        protected virtual void OnSceneGUI();
        public void FixNegativeSize();
        public void LookAt(Vector3 point);
        public void LookAt(Vector3 point, Quaternion direction);
        public void LookAtDirect(Vector3 point, Quaternion direction);
        public void LookAt(Vector3 point, Quaternion direction, float newSize);
        public void LookAtDirect(Vector3 point, Quaternion direction, float newSize);
        public void LookAt(Vector3 point, Quaternion direction, float newSize, bool ortho);
        public void LookAt(Vector3 point, Quaternion direction, float newSize, bool ortho, bool instant);
        public void AlignViewToObject(Transform t);
        public void AlignWithView();
        public void MoveToView();
        public void MoveToView(Transform target);
        public bool FrameSelected();
        public bool FrameSelected(bool lockView);
        public virtual bool FrameSelected(bool lockView, bool instant);
        public bool Frame(Bounds bounds, bool instant = True);
        public static CameraMode AddCameraMode(string name, string section);
        public static void ClearUserDefinedCameraModes();
        public static CameraMode GetBuiltinCameraMode(DrawCameraMode mode);

        public struct CameraMode
        {
            public DrawCameraMode drawMode;
            public string name;
            public string section;

            public override bool Equals(object otherObject);
            public override int GetHashCode();
            public override string ToString();

            public static bool operator ==(CameraMode a, CameraMode z);
            public static bool operator !=(CameraMode a, CameraMode z);
        }
        public class SceneViewState
        {
            public bool showFog;
            public bool showSkybox;
            public bool showFlares;
            public bool showImageEffects;
            public bool showParticleSystems;
            public bool showVisualEffectGraphs;

            public SceneViewState();
            public SceneViewState(SceneViewState other);

            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Obsolete msg (UnityUpgradable) -> alwaysRefresh")]
            public bool showMaterialUpdate { get; set; }
            public bool alwaysRefresh { get; set; }
            public bool fogEnabled { get; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Obsolete msg (UnityUpgradable) -> alwaysRefreshEnabled")]
            public bool materialUpdateEnabled { get; }
            public bool alwaysRefreshEnabled { get; }
            public bool skyboxEnabled { get; }
            public bool flaresEnabled { get; }
            public bool imageEffectsEnabled { get; }
            public bool particleSystemsEnabled { get; }
            public bool visualEffectGraphsEnabled { get; }
            public bool allEnabled { get; }
            public bool fxEnabled { get; set; }

            [Obsolete("IsAllOn() has been deprecated. Use allEnabled instead (UnityUpgradable) -> allEnabled")]
            public bool IsAllOn();
            [Obsolete("Toggle() has been deprecated. Use SetAllEnabled() instead (UnityUpgradable) -> SetAllEnabled(*)")]
            public void Toggle(bool value);
            public void SetAllEnabled(bool value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("OnSceneFunc() has been deprecated. Use System.Action instead.")]
        public delegate void OnSceneFunc(SceneView sceneView);
        public class CameraSettings
        {
            public CameraSettings();

            public float speed { get; set; }
            public float speedNormalized { get; set; }
            public float speedMin { get; set; }
            public float speedMax { get; set; }
            public bool easingEnabled { get; set; }
            public float easingDuration { get; set; }
            public bool accelerationEnabled { get; set; }
            public float fieldOfView { get; set; }
            public float nearClip { get; set; }
            public float farClip { get; set; }
            public bool dynamicClip { get; set; }
            public bool occlusionCulling { get; set; }
        }
    }
}
