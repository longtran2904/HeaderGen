#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class ParticleGUI
    {
        public static void SetupMaterialWithColorMode(Material material);
        public static void FadingOptions(Material material, MaterialEditor materialEditor, ParticleProperties properties);
        public static void DoVertexStreamsArea(Material material, List<ParticleSystemRenderer> renderers, bool useLighting = False);
        public static void SetMaterialKeywords(Material material);

        public enum ColorMode
        {
            Multiply = 0,
            Additive = 1,
            Subtractive = 2,
            Overlay = 3,
            Color = 4,
            Difference = 5
        }
        public static class Styles
        {
            public static GUIContent colorMode;
            public static GUIContent flipbookMode;
            public static GUIContent softParticlesEnabled;
            public static GUIContent softParticlesFadeText;
            public static GUIContent softParticlesNearFadeDistanceText;
            public static GUIContent softParticlesFarFadeDistanceText;
            public static GUIContent cameraFadingEnabled;
            public static GUIContent cameraFadingDistanceText;
            public static GUIContent cameraNearFadeDistanceText;
            public static GUIContent cameraFarFadeDistanceText;
            public static GUIContent distortionEnabled;
            public static GUIContent distortionStrength;
            public static GUIContent distortionBlend;
            public static GUIContent VertexStreams;
            public static string streamPositionText;
            public static string streamNormalText;
            public static string streamColorText;
            public static string streamColorInstancedText;
            public static string streamUVText;
            public static string streamUV2Text;
            public static string streamAnimBlendText;
            public static string streamAnimFrameText;
            public static string streamTangentText;
            public static GUIContent streamApplyToAllSystemsText;
            public static string undoApplyCustomVertexStreams;
            public static GUIStyle vertexStreamIcon;
        }
        public struct ParticleProperties
        {
            public MaterialProperty colorMode;
            public MaterialProperty flipbookMode;
            public MaterialProperty softParticlesEnabled;
            public MaterialProperty cameraFadingEnabled;
            public MaterialProperty distortionEnabled;
            public MaterialProperty softParticlesNearFadeDistance;
            public MaterialProperty softParticlesFarFadeDistance;
            public MaterialProperty cameraNearFadeDistance;
            public MaterialProperty cameraFarFadeDistance;
            public MaterialProperty distortionBlend;
            public MaterialProperty distortionStrength;

            public ParticleProperties(MaterialProperty[] properties);
        }
    }
}
