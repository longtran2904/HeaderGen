#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public sealed class LensFlareDataElementSRP
    {
        public bool visible;
        public float position;
        public Vector2 positionOffset;
        public float angularOffset;
        public Vector2 translationScale;
        public Texture lensFlareTexture;
        public float uniformScale;
        public Vector2 sizeXY;
        public bool allowMultipleElement;
        public bool preserveAspectRatio;
        public float rotation;
        public Color tint;
        public SRPLensFlareBlendMode blendMode;
        public bool autoRotate;
        public SRPLensFlareType flareType;
        public bool modulateByLightColor;
        public SRPLensFlareDistribution distribution;
        public float lengthSpread;
        public AnimationCurve positionCurve;
        public AnimationCurve scaleCurve;
        public int seed;
        public Gradient colorGradient;
        public Vector2 positionVariation;
        public float scaleVariation;
        public float rotationVariation;
        public bool enableRadialDistortion;
        public Vector2 targetSizeDistortion;
        public AnimationCurve distortionCurve;
        public bool distortionRelativeToCenter;
        public bool inverseSDF;
        public float uniformAngle;
        public AnimationCurve uniformAngleCurve;

        public LensFlareDataElementSRP();

        public float localIntensity { get; set; }
        public int count { get; set; }
        public float intensityVariation { get; set; }
        public float fallOff { get; set; }
        public float edgeOffset { get; set; }
        public int sideCount { get; set; }
        public float sdfRoundness { get; set; }
    }
}
