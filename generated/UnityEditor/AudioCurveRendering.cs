#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class AudioCurveRendering
    {
        public static readonly Color kAudioOrange;

        public AudioCurveRendering();

        public static Rect BeginCurveFrame(Rect r);
        public static void EndCurveFrame();
        public static Rect DrawCurveFrame(Rect r);
        public static void DrawCurveBackground(Rect r);
        public static void DrawFilledCurve(Rect r, AudioCurveEvaluator eval, Color curveColor);
        public static void DrawFilledCurve(Rect r, AudioCurveAndColorEvaluator eval);
        public static void DrawMinMaxFilledCurve(Rect r, AudioMinMaxCurveAndColorEvaluator eval);
        public static void DrawSymmetricFilledCurve(Rect r, AudioCurveAndColorEvaluator eval);
        public static void DrawCurve(Rect r, AudioCurveEvaluator eval, Color curveColor);
        public static void DrawGradientRect(Rect r, Color c1, Color c2, float blend, bool horizontal);

        public delegate float AudioCurveEvaluator(float x);
        public delegate float AudioCurveAndColorEvaluator(float x, out Color col);
        public delegate void AudioMinMaxCurveAndColorEvaluator(float x, out Color col, out float minValue, out float maxValue);
    }
}
