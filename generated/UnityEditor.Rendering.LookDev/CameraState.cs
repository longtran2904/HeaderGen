#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.LookDev
{
    public class CameraState : ICameraUpdater
    {

        public CameraState();

        public Vector3 pivot { get; set; }
        public Quaternion rotation { get; set; }
        public float viewSize { get; set; }
        public float distanceFromPivot { get; }
        public Vector3 position { get; }
        public float fieldOfView { get; }
        public float farClip { get; }
        public float nearClip { get; }
        public Vector3 forward { get; }
        public Vector3 up { get; }
        public Vector3 right { get; }

        public void UpdateCamera(Camera camera);
        public void Reset();
    }
}
