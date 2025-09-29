#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEditor.AssetImporters;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public class IESImporterEditor
    {
        protected SerializedProperty m_LightAimAxisRotationProp;
        protected PreviewRenderUtility m_PreviewRenderUtility;

        public IESImporterEditor();

        public void CommonOnEnable(SerializedProperty serializedObject);
        public void CommonOnInspectorGUI(ScriptedImporterEditor scriptedImporter);
        public void CommonApply();
        public bool CommonHasPreviewGUI(SetupRenderPipelinePreviewCamera setupRenderPipelinePreviewCamera, SetupRenderPipelinePreviewLight setupRenderPipelinePreviewLight, SetupRenderPipelinePreviewWallRenderer setupRenderPipelinePreviewWallRenderer, SetupRenderPipelinePreviewFloorRenderer setupRenderPipelinePreviewFloorRenderer);
        public GUIContent CommonGetPreviewTitle();
        public void CommonOnPreviewGUI(Rect r, GUIStyle background, ScriptedImporter target, SetupRenderPipelinePreviewLightIntensity setupRenderPipelinePreviewLightIntensity);
        public void CommonOnDisable();

        public delegate void LayoutRenderPipelineUseIesMaximumIntensity();
        public delegate void SetupRenderPipelinePreviewCamera(Camera camera);
        public delegate void SetupRenderPipelinePreviewLight(Light light);
        public delegate void SetupRenderPipelinePreviewWallRenderer(MeshRenderer wallRenderer);
        public delegate void SetupRenderPipelinePreviewFloorRenderer(MeshRenderer floorRenderer);
        public delegate void SetupRenderPipelinePreviewLightIntensity(Light light, SerializedProperty useIESMaximumIntensityProp, SerializedProperty iesMaximumIntensityUnitProp, SerializedProperty iesMaximumIntensityProp);
    }
}
