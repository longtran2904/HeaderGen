#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Light))]
    public class LightEditor : Editor
    {
        protected static readonly Color kGizmoLight;
        protected static readonly Color kGizmoDisabledLight;

        public LightEditor();

        protected Settings settings { get; }

        protected virtual void OnEnable();
        protected virtual void OnDestroy();
        public override void OnInspectorGUI();
        protected virtual void OnSceneGUI();

        public sealed class Settings
        {
            public Settings(SerializedObject so);

            public SerializedProperty lightType { get; }
            public SerializedProperty lightShape { get; }
            public SerializedProperty range { get; }
            public SerializedProperty spotAngle { get; }
            public SerializedProperty innerSpotAngle { get; }
            public SerializedProperty cookieSize { get; }
            public SerializedProperty color { get; }
            public SerializedProperty intensity { get; }
            public SerializedProperty bounceIntensity { get; }
            public SerializedProperty colorTemperature { get; }
            public SerializedProperty useColorTemperature { get; }
            public SerializedProperty cookieProp { get; }
            public SerializedProperty shadowsType { get; }
            public SerializedProperty shadowsStrength { get; }
            public SerializedProperty shadowsResolution { get; }
            public SerializedProperty shadowsBias { get; }
            public SerializedProperty shadowsNormalBias { get; }
            public SerializedProperty shadowsNearPlane { get; }
            public SerializedProperty halo { get; }
            public SerializedProperty flare { get; }
            public SerializedProperty renderMode { get; }
            public SerializedProperty cullingMask { get; }
            public SerializedProperty renderingLayerMask { get; }
            public SerializedProperty lightmapping { get; }
            public SerializedProperty areaSizeX { get; }
            public SerializedProperty areaSizeY { get; }
            public SerializedProperty bakedShadowRadiusProp { get; }
            public SerializedProperty bakedShadowAngleProp { get; }
            public bool isRealtime { get; }
            public bool isMixed { get; }
            public bool isCompletelyBaked { get; }
            public bool isBakedOrMixed { get; }
            public bool isAreaLightType { get; }
            public Light light { get; }
            public Texture cookie { get; }

            public void OnEnable();
            public void OnDestroy();
            public void Update();
            public void DrawLightType();
            public void DrawRange();
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("showAreaOptions argument for DrawRange(showAreaOptions) has been removed. Use DrawRange() instead (UnityUpgradable).")]
            public void DrawRange(bool showAreaOptions);
            public void DrawSpotAngle();
            public void DrawInnerAndOuterSpotAngle();
            public void DrawArea();
            public void DrawColor();
            public void DrawLightmapping();
            public void DrawIntensity();
            public void DrawBounceIntensity();
            public void DrawCookie();
            public void DrawCookieSize();
            public void DrawHalo();
            public void DrawFlare();
            public void DrawRenderMode();
            public void DrawCullingMask();
            public void DrawRenderingLayerMask();
            public void ApplyModifiedProperties();
            public void DrawShadowsType();
            public void DrawBakedShadowRadius();
            public void DrawBakedShadowAngle();
            public void DrawRuntimeShadow();
        }
    }
}
