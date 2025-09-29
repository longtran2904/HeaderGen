#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
    [AddComponentMenu("Rendering/2D/Shadow Caster 2D")]
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    [MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
    public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver
    {
        public ShadowCaster2D();

        public Mesh mesh { get; }
        public Vector3[] shapePath { get; }
        public bool useRendererSilhouette { get; set; }
        public bool selfShadows { get; set; }
        public bool castsShadows { get; set; }

        protected void OnEnable();
        protected void OnDisable();
        public void Update();
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();

        public enum ComponentVersions
        {
            Version_Unserialized = 0,
            Version_1 = 1
        }
    }
}
