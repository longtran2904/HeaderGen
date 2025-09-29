#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [Il2CppEagerStaticClassConstruction]
    [NativeHeader("Runtime/Math/PerlinNoise.h")]
    [NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
    [NativeHeader("Runtime/Utilities/BitUtility.h")]
    [NativeHeader("Runtime/Math/FloatConversion.h")]
    public struct Mathf
    {

        public static readonly float Epsilon;
        public const float PI = 3.1415927F;
        public const float Infinity = ∞F;
        public const float NegativeInfinity = -∞F;
        public const float Deg2Rad = 0.017453292F;
        public const float Rad2Deg = 57.29578F;

        [FreeFunction(IsThreadSafe = True)]
        public static int ClosestPowerOfTwo(int value);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsPowerOfTwo(int value);
        [FreeFunction(IsThreadSafe = True)]
        public static int NextPowerOfTwo(int value);
        [FreeFunction(IsThreadSafe = True)]
        public static float GammaToLinearSpace(float value);
        [FreeFunction(IsThreadSafe = True)]
        public static float LinearToGammaSpace(float value);
        [FreeFunction(IsThreadSafe = True)]
        public static Color CorrelatedColorTemperatureToRGB(float kelvin);
        [FreeFunction(IsThreadSafe = True)]
        public static ushort FloatToHalf(float val);
        [FreeFunction(IsThreadSafe = True)]
        public static float HalfToFloat(ushort val);
        [FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
        public static float PerlinNoise(float x, float y);
        public static float Sin(float f);
        public static float Cos(float f);
        public static float Tan(float f);
        public static float Asin(float f);
        public static float Acos(float f);
        public static float Atan(float f);
        public static float Atan2(float y, float x);
        public static float Sqrt(float f);
        public static float Abs(float f);
        public static int Abs(int value);
        public static float Min(float a, float b);
        public static float Min(params float[] values);
        public static int Min(int a, int b);
        public static int Min(params int[] values);
        public static float Max(float a, float b);
        public static float Max(params float[] values);
        public static int Max(int a, int b);
        public static int Max(params int[] values);
        public static float Pow(float f, float p);
        public static float Exp(float power);
        public static float Log(float f, float p);
        public static float Log(float f);
        public static float Log10(float f);
        public static float Ceil(float f);
        public static float Floor(float f);
        public static float Round(float f);
        public static int CeilToInt(float f);
        public static int FloorToInt(float f);
        public static int RoundToInt(float f);
        public static float Sign(float f);
        public static float Clamp(float value, float min, float max);
        public static int Clamp(int value, int min, int max);
        public static float Clamp01(float value);
        public static float Lerp(float a, float b, float t);
        public static float LerpUnclamped(float a, float b, float t);
        public static float LerpAngle(float a, float b, float t);
        public static float MoveTowards(float current, float target, float maxDelta);
        public static float MoveTowardsAngle(float current, float target, float maxDelta);
        public static float SmoothStep(float from, float to, float t);
        public static float Gamma(float value, float absmax, float gamma);
        public static bool Approximately(float a, float b);
        [ExcludeFromDocs]
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed);
        [ExcludeFromDocs]
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime);
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime);
        [ExcludeFromDocs]
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed);
        [ExcludeFromDocs]
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime);
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime);
        public static float Repeat(float t, float length);
        public static float PingPong(float t, float length);
        public static float InverseLerp(float a, float b, float value);
        public static float DeltaAngle(float current, float target);
    }
}
