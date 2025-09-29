#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    [AddComponentMenu("Rendering/Lens Flare (SRP)")]
    [ExecuteAlways]
    public sealed class LensFlareComponentSRP : MonoBehaviour
    {

        [Min(0)]
        public float intensity;
        [Min(1E-05F)]
        public float maxAttenuationDistance;
        [Min(1E-05F)]
        public float maxAttenuationScale;
        public AnimationCurve distanceAttenuationCurve;
        public AnimationCurve scaleByDistanceCurve;
        public bool attenuationByLightShape;
        public AnimationCurve radialScreenAttenuationCurve;
        public bool useOcclusion;
        [Min(0)]
        public float occlusionRadius;
        [Range(1, 64)]
        public uint sampleCount;
        public float occlusionOffset;
        [Min(0)]
        public float scale;
        public bool allowOffScreen;

        public LensFlareComponentSRP();

        public LensFlareDataSRP lensFlareData { get; set; }

        public float celestialProjectedOcclusionRadius(Camera mainCam);
    }
}
