#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.LookDev
{
    public class ViewContext
    {
        public ViewContext();

        public CameraState camera { get; }
        public DebugContext debug { get; }
        public bool hasEnvironment { get; }
        public Environment environment { get; }
        public bool hasViewedObject { get; }
        public GameObject viewedObjectReference { get; }
        public GameObject viewedInstanceInPreview { get; }

        public void UpdateEnvironment(UnityEngine.Object environmentOrCubemapAsset);
        public void UpdateViewedObject(GameObject viewedObject);
        public void ResetCameraState();
    }
}
