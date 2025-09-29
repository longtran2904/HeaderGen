#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class SimpleLitGUI
    {
        public static void Inputs(SimpleLitProperties properties, MaterialEditor materialEditor, Material material);
        public static void Advanced(SimpleLitProperties properties);
        public static void DoSpecularArea(SimpleLitProperties properties, MaterialEditor materialEditor, Material material);
        public static void SetMaterialKeywords(Material material);

        public enum SpecularSource
        {
            SpecularTextureAndColor = 0,
            NoSpecular = 1
        }
        public enum SmoothnessMapChannel
        {
            SpecularAlpha = 0,
            AlbedoAlpha = 1
        }
        public static class Styles
        {
            public static GUIContent specularMapText;
        }
        public struct SimpleLitProperties
        {
            public MaterialProperty specColor;
            public MaterialProperty specGlossMap;
            public MaterialProperty specHighlights;
            public MaterialProperty smoothnessMapChannel;
            public MaterialProperty smoothness;
            public MaterialProperty bumpMapProp;

            public SimpleLitProperties(MaterialProperty[] properties);
        }
    }
}
