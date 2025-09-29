#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/RenderSettings.h")]
    [NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
    [StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
    public sealed class RenderSettings : Object
    {
        [Obsolete("Use RenderSettings.ambientIntensity instead (UnityUpgradable) -> ambientIntensity", False)]
        public static float ambientSkyboxAmount { get; set; }
        [NativeProperty("UseFog")]
        public static bool fog { get; set; }
        [NativeProperty("LinearFogStart")]
        public static float fogStartDistance { get; set; }
        [NativeProperty("LinearFogEnd")]
        public static float fogEndDistance { get; set; }
        public static FogMode fogMode { get; set; }
        public static Color fogColor { get; set; }
        public static float fogDensity { get; set; }
        public static AmbientMode ambientMode { get; set; }
        public static Color ambientSkyColor { get; set; }
        public static Color ambientEquatorColor { get; set; }
        public static Color ambientGroundColor { get; set; }
        public static float ambientIntensity { get; set; }
        [NativeProperty("AmbientSkyColor")]
        public static Color ambientLight { get; set; }
        public static Color subtractiveShadowColor { get; set; }
        [NativeProperty("SkyboxMaterial")]
        public static Material skybox { get; set; }
        public static Light sun { get; set; }
        public static SphericalHarmonicsL2 ambientProbe { get; set; }
        public static Texture customReflection { get; set; }
        public static float reflectionIntensity { get; set; }
        public static int reflectionBounces { get; set; }
        public static DefaultReflectionMode defaultReflectionMode { get; set; }
        public static int defaultReflectionResolution { get; set; }
        public static float haloStrength { get; set; }
        public static float flareStrength { get; set; }
        public static float flareFadeSpeed { get; set; }
    }
}
