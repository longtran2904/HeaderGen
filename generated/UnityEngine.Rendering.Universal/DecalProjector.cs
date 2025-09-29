#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using UnityEditor;

namespace UnityEngine.Rendering.Universal
{
    [AddComponentMenu("Rendering/URP Decal Projector")]
    [CanEditMultipleObjects]
    [ExecuteAlways]
    public class DecalProjector : MonoBehaviour
    {

        public DecalProjector();

        public Material material { get; set; }
        public float drawDistance { get; set; }
        public float fadeScale { get; set; }
        public float startAngleFade { get; set; }
        public float endAngleFade { get; set; }
        public Vector2 uvScale { get; set; }
        public Vector2 uvBias { get; set; }
        public DecalScaleMode scaleMode { get; set; }
        public Vector3 pivot { get; set; }
        public Vector3 size { get; set; }
        public float fadeFactor { get; set; }

        public bool IsValid();
    }
}
