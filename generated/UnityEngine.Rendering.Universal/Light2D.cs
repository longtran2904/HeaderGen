#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.U2D;

namespace UnityEngine.Rendering.Universal
{
    [AddComponentMenu("Rendering/2D/Light 2D")]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DLightProperties.html")]
    [MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
    public sealed class Light2D : Light2DBase, ISerializationCallbackReceiver
    {
        public Light2D();

        public LightType lightType { get; set; }
        public int blendStyleIndex { get; set; }
        public float shadowIntensity { get; set; }
        public bool shadowsEnabled { get; set; }
        public float shadowVolumeIntensity { get; set; }
        public bool volumetricShadowsEnabled { get; set; }
        public Color color { get; set; }
        public float intensity { get; set; }
        [Obsolete]
        public float volumeOpacity { get; }
        public float volumeIntensity { get; set; }
        public bool volumeIntensityEnabled { get; set; }
        public Sprite lightCookieSprite { get; set; }
        public float falloffIntensity { get; set; }
        [Obsolete]
        public bool alphaBlendOnOverlap { get; }
        public OverlapOperation overlapOperation { get; set; }
        public int lightOrder { get; set; }
        public float normalMapDistance { get; }
        public NormalMapQuality normalMapQuality { get; }
        public bool renderVolumetricShadows { get; }
        public float pointLightInnerAngle { get; set; }
        public float pointLightOuterAngle { get; set; }
        public float pointLightInnerRadius { get; set; }
        public float pointLightOuterRadius { get; set; }
        [Obsolete("pointLightDistance has been changed to normalMapDistance", True)]
        public float pointLightDistance { get; }
        [Obsolete("pointLightQuality has been changed to normalMapQuality", True)]
        public NormalMapQuality pointLightQuality { get; }
        public int shapeLightParametricSides { get; }
        public float shapeLightParametricAngleOffset { get; }
        public float shapeLightParametricRadius { get; }
        public float shapeLightFalloffSize { get; set; }
        public Vector3[] shapePath { get; }

        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
        public void SetShapePath(Vector3[] path);

        public enum DeprecatedLightType
        {
            Parametric = 0
        }
        public enum LightType
        {
            Parametric = 0,
            Freeform = 1,
            Sprite = 2,
            Point = 3,
            Global = 4
        }
        public enum NormalMapQuality
        {
            Disabled = 2,
            Fast = 0,
            Accurate = 1
        }
        public enum OverlapOperation
        {
            Additive = 0,
            AlphaBlend = 1
        }
    }
}
