#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class LitGUI
    {
        public static void Inputs(LitProperties properties, MaterialEditor materialEditor, Material material);
        public static void DoClearCoat(LitProperties properties, MaterialEditor materialEditor, Material material);
        public static void DoMetallicSpecularArea(LitProperties properties, MaterialEditor materialEditor, Material material);
        public static void DoSmoothness(MaterialEditor materialEditor, Material material, MaterialProperty smoothness, MaterialProperty smoothnessMapChannel, string[] smoothnessChannelNames);
        public static SmoothnessMapChannel GetSmoothnessMapChannel(Material material);
        public static void SetMaterialKeywords(Material material);

        public enum WorkflowMode
        {
            Specular = 0,
            Metallic = 1
        }
        public enum SmoothnessMapChannel
        {
            SpecularMetallicAlpha = 0,
            AlbedoAlpha = 1
        }
        public static class Styles
        {
            public static GUIContent workflowModeText;
            public static GUIContent specularMapText;
            public static GUIContent metallicMapText;
            public static GUIContent smoothnessText;
            public static GUIContent smoothnessMapChannelText;
            public static GUIContent highlightsText;
            public static GUIContent reflectionsText;
            public static GUIContent heightMapText;
            public static GUIContent occlusionText;
            public static readonly string[] metallicSmoothnessChannelNames;
            public static readonly string[] specularSmoothnessChannelNames;
            public static GUIContent clearCoatText;
            public static GUIContent clearCoatMaskText;
            public static GUIContent clearCoatSmoothnessText;
        }
        public struct LitProperties
        {
            public MaterialProperty workflowMode;
            public MaterialProperty metallic;
            public MaterialProperty specColor;
            public MaterialProperty metallicGlossMap;
            public MaterialProperty specGlossMap;
            public MaterialProperty smoothness;
            public MaterialProperty smoothnessMapChannel;
            public MaterialProperty bumpMapProp;
            public MaterialProperty bumpScaleProp;
            public MaterialProperty parallaxMapProp;
            public MaterialProperty parallaxScaleProp;
            public MaterialProperty occlusionStrength;
            public MaterialProperty occlusionMap;
            public MaterialProperty highlights;
            public MaterialProperty reflections;
            public MaterialProperty clearCoat;
            public MaterialProperty clearCoatMap;
            public MaterialProperty clearCoatMask;
            public MaterialProperty clearCoatSmoothness;

            public LitProperties(MaterialProperty[] properties);
        }
    }
}
