#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine
{
    [AddComponentMenu("Rendering/Light Anchor")]
    [CoreRPHelpURL("View-Lighting-Tool", "com.unity.render-pipelines.core")]
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class LightAnchor : MonoBehaviour
    {
        public LightAnchor();

        public float yaw { get; set; }
        public float pitch { get; set; }
        public float roll { get; set; }
        public float distance { get; set; }
        public UpDirection frameSpace { get; set; }
        public Vector3 anchorPosition { get; }
        public Transform anchorPositionOverride { get; set; }
        public Vector3 anchorPositionOffset { get; set; }

        public static float NormalizeAngleDegree(float angle);
        public void SynchronizeOnTransform(Camera camera);
        public void UpdateTransform(Camera camera, Vector3 anchor);

        public enum UpDirection
        {
            World = 0,
            Local = 1
        }
    }
}
