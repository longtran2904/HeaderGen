#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class ColorUtils
    {
        public static float s_LightMeterCalibrationConstant;
        public static float s_LensAttenuation;

        public static float lensImperfectionExposureScale { get; }

        public static float StandardIlluminantY(float x);
        public static Vector3 CIExyToLMS(float x, float y);
        public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint);
        public static (Vector4, Vector4, Vector4) PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights);
        public static (Vector4, Vector4, Vector4) PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain);
        public static (Vector4, Vector4) PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance);
        public static float Luminance(in Color color);
        public static float ComputeEV100(float aperture, float shutterSpeed, float ISO);
        public static float ConvertEV100ToExposure(float EV100);
        public static float ConvertExposureToEV100(float exposure);
        public static float ComputeEV100FromAvgLuminance(float avgLuminance);
        public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100);
        public static uint ToHex(Color c);
        public static Color ToRGBA(uint hex);
    }
}
