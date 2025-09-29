#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Random/Random.bindings.h")]
    public static class Random
    {

        [StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
        public static State state { get; set; }
        public static float value { get; }
        public static Vector3 insideUnitSphere { get; }
        public static Vector2 insideUnitCircle { get; }
        public static Vector3 onUnitSphere { get; }
        public static Quaternion rotation { get; }
        public static Quaternion rotationUniform { get; }
        [Obsolete("Deprecated. Use InitState() function or Random.state property instead.")]
        [StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
        public static int seed { get; set; }

        [NativeMethod("SetSeed")]
        [StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
        public static void InitState(int seed);
        [FreeFunction]
        public static float Range(float minInclusive, float maxInclusive);
        public static int Range(int minInclusive, int maxExclusive);
        [Obsolete("Use Random.Range instead")]
        public static float RandomRange(float min, float max);
        [Obsolete("Use Random.Range instead")]
        public static int RandomRange(int min, int max);
        public static Color ColorHSV();
        public static Color ColorHSV(float hueMin, float hueMax);
        public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax);
        public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax);
        public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax);
        public struct State
        {
        }
    }
}
