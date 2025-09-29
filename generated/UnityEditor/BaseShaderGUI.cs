#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using System;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace UnityEditor
{
    public abstract class BaseShaderGUI : ShaderGUI
    {

        public bool m_FirstTimeApply;

        protected BaseShaderGUI();

        protected MaterialEditor materialEditor { get; set; }
        protected MaterialProperty surfaceTypeProp { get; set; }
        protected MaterialProperty blendModeProp { get; set; }
        protected MaterialProperty cullingProp { get; set; }
        protected MaterialProperty ztestProp { get; set; }
        protected MaterialProperty zwriteProp { get; set; }
        protected MaterialProperty alphaClipProp { get; set; }
        protected MaterialProperty alphaCutoffProp { get; set; }
        protected MaterialProperty castShadowsProp { get; set; }
        protected MaterialProperty receiveShadowsProp { get; set; }
        protected MaterialProperty baseMapProp { get; set; }
        protected MaterialProperty baseColorProp { get; set; }
        protected MaterialProperty emissionMapProp { get; set; }
        protected MaterialProperty emissionColorProp { get; set; }
        protected MaterialProperty queueOffsetProp { get; set; }
        protected MaterialProperty queueControlProp { get; set; }
        protected virtual uint materialFilter { get; }

        [Obsolete("MaterialChanged has been renamed ValidateMaterial", False)]
        public virtual void MaterialChanged(Material material);
        public virtual void FindProperties(MaterialProperty[] properties);
        public override void OnGUI(MaterialEditor materialEditorIn, MaterialProperty[] properties);
        public virtual void OnOpenGUI(Material material, MaterialEditor materialEditor);
        public void ShaderPropertiesGUI(Material material);
        public virtual void DrawSurfaceOptions(Material material);
        public virtual void DrawSurfaceInputs(Material material);
        public virtual void DrawAdvancedOptions(Material material);
        protected void DrawQueueOffsetField();
        [Obsolete("DrawAdditionalFoldouts has been deprecated. Use FillAdditionalFoldouts instead, and materialScopesList.RegisterHeaderScope", False)]
        public virtual void DrawAdditionalFoldouts(Material material);
        public virtual void FillAdditionalFoldouts(MaterialHeaderScopeList materialScopesList);
        public virtual void DrawBaseProperties(Material material);
        protected virtual void DrawEmissionProperties(Material material, bool keyword);
        public static void DrawNormalArea(MaterialEditor materialEditor, MaterialProperty bumpMap, MaterialProperty bumpMapScale = null);
        protected static void DrawTileOffset(MaterialEditor materialEditor, MaterialProperty textureProp);
        public static void SetMaterialKeywords(Material material, Action<Material> shadingModelFunc = null, Action<Material> shaderFunc = null);
        public static void SetupMaterialBlendMode(Material material);
        public override void AssignNewShaderToMaterial(Material material, Shader oldShader, Shader newShader);
        public static void TwoFloatSingleLine(GUIContent title, MaterialProperty prop1, GUIContent prop1Label, MaterialProperty prop2, GUIContent prop2Label, MaterialEditor materialEditor, float labelWidth = 30);
        public void DoPopup(GUIContent label, MaterialProperty property, string[] options);
        public static Rect TextureColorProps(MaterialEditor materialEditor, GUIContent label, MaterialProperty textureProp, MaterialProperty colorProp, bool hdr = False);
        public static MaterialProperty FindProperty(string propertyName, MaterialProperty[] properties);
        public static MaterialProperty FindProperty(string propertyName, MaterialProperty[] properties, bool propertyIsMandatory);
        [Flags]
        [URPHelpURL("shaders-in-universalrp")]
        protected enum Expandable
        {

            SurfaceOptions = 1,
            SurfaceInputs = 2,
            Advanced = 4,
            Details = 8
        }
        public enum SurfaceType
        {

            Opaque = 0,
            Transparent = 1
        }
        public enum BlendMode
        {

            Alpha = 0,
            Premultiply = 1,
            Additive = 2,
            Multiply = 3
        }
        public enum SmoothnessSource
        {

            SpecularAlpha = 0,
            BaseAlpha = 1
        }
        public enum RenderFace
        {

            Front = 2,
            Back = 1,
            Both = 0
        }
        public enum QueueControl
        {

            Auto = 0,
            UserOverride = 1
        }
        protected class Styles
        {

            public static readonly string[] surfaceTypeNames;
            public static readonly string[] blendModeNames;
            public static readonly string[] renderFaceNames;
            public static readonly string[] zwriteNames;
            public static readonly string[] queueControlNames;
            public static readonly int[] ztestValues;
            public static readonly string[] ztestNames;
            public static readonly GUIContent SurfaceOptions;
            public static readonly GUIContent SurfaceInputs;
            public static readonly GUIContent AdvancedLabel;
            public static readonly GUIContent surfaceType;
            public static readonly GUIContent blendingMode;
            public static readonly GUIContent cullingText;
            public static readonly GUIContent zwriteText;
            public static readonly GUIContent ztestText;
            public static readonly GUIContent alphaClipText;
            public static readonly GUIContent alphaClipThresholdText;
            public static readonly GUIContent castShadowText;
            public static readonly GUIContent receiveShadowText;
            public static readonly GUIContent baseMap;
            public static readonly GUIContent emissionMap;
            public static readonly GUIContent normalMapText;
            public static readonly GUIContent bumpScaleNotSupported;
            public static readonly GUIContent fixNormalNow;
            public static readonly GUIContent queueSlider;
            public static readonly GUIContent queueControl;
            public static readonly GUIContent documentationIcon;

            public Styles();
        }
    }
}
