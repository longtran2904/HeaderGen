#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public static class CameraEditorUtils
    {

        public static Material GUITextureBlit2SRGBMaterial { get; }

        public static void DrawCameraSceneViewOverlay(UnityEngine.Object target, SceneView sceneView, GetPreviewCamera previewCameraGetter);
        public static bool IsViewPortRectValidToRender(Rect normalizedViewPortRect);
        public delegate Camera GetPreviewCamera(Camera sourceCamera, Vector2 previewSize);
    }
}
