#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class HableCurve
    {

        public readonly Segment[] segments;
        public readonly Uniforms uniforms;

        public HableCurve();

        public float whitePoint { get; }
        public float inverseWhitePoint { get; }
        public float x0 { get; }
        public float x1 { get; }

        public float Eval(float x);
        public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
        public class Segment
        {

            public float offsetX;
            public float offsetY;
            public float scaleX;
            public float scaleY;
            public float lnA;
            public float B;

            public Segment();

            public float Eval(float x);
        }
        public class Uniforms
        {

            public Vector4 curve { get; }
            public Vector4 toeSegmentA { get; }
            public Vector4 toeSegmentB { get; }
            public Vector4 midSegmentA { get; }
            public Vector4 midSegmentB { get; }
            public Vector4 shoSegmentA { get; }
            public Vector4 shoSegmentB { get; }
        }
    }
}
