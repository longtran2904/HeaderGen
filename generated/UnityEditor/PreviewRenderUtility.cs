#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public class PreviewRenderUtility
    {

        [Obsolete("Use the property camera instead (UnityUpgradable) -> camera", False)]
        public Camera m_Camera;
        [Obsolete("Use the property cameraFieldOfView (UnityUpgradable) -> cameraFieldOfView", False)]
        public float m_CameraFieldOfView;
        [Obsolete("Use the property lights (UnityUpgradable) -> lights", False)]
        public Light[] m_Light;

        public PreviewRenderUtility(bool renderFullScene);
        public PreviewRenderUtility(bool renderFullScene, bool pixelPerfect);
        public PreviewRenderUtility();

        ~PreviewRenderUtility();

        public Camera camera { get; }
        public float cameraFieldOfView { get; set; }
        public Color ambientColor { get; set; }
        public Light[] lights { get; }

        public void Cleanup();
        public void BeginPreview(Rect r, GUIStyle previewBackground);
        public void BeginStaticPreview(Rect r);
        public float GetScaleFactor(float width, float height);
        [Obsolete("This method has been marked obsolete, use BeginStaticPreview() instead (UnityUpgradable) -> BeginStaticPreview(*)", False)]
        public void BeginStaticPreviewHDR(Rect r);
        [Obsolete("This method has been marked obsolete, use BeginPreview() instead (UnityUpgradable) -> BeginPreview(*)", False)]
        public void BeginPreviewHDR(Rect r, GUIStyle previewBackground);
        public Texture EndPreview();
        public void EndAndDrawPreview(Rect r);
        public Texture2D EndStaticPreview();
        [Obsolete("AddSingleGO(GameObject go, bool instantiateAtZero) has been deprecated, use AddSingleGo(GameObject go) instead. instantiateAtZero has no effect and is not supported.")]
        public void AddSingleGO(GameObject go, bool instantiateAtZero);
        public void AddSingleGO(GameObject go);
        public GameObject InstantiatePrefabInScene(GameObject prefab);
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material mat, int subMeshIndex);
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties);
        public void DrawMesh(Mesh mesh, Matrix4x4 m, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor, bool useLightProbe);
        public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex);
        public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties);
        public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor);
        public void DrawMesh(Mesh mesh, Vector3 pos, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor, bool useLightProbe);
        public void DrawMesh(Mesh mesh, Vector3 pos, Vector3 scale, Quaternion rot, Material mat, int subMeshIndex, MaterialPropertyBlock customProperties, Transform probeAnchor, bool useLightProbe);
        protected static GameObject CreateLight();
        public void Render(bool allowScriptableRenderPipeline = False, bool updatefov = True);
    }
}
