#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Material))]
    public class MaterialEditor : Editor
    {

        public const int kMiniTextureFieldLabelIndentLevel = 2;

        public MaterialEditor();

        public bool isVisible { get; }
        public ShaderGUI customShaderGUI { get; }

        public void SetShader(Shader shader);
        public void SetShader(Shader newShader, bool registerUndo);
        public virtual void Awake();
        public override void OnInspectorGUI();
        public void PropertiesChanged();
        protected virtual void OnShaderChanged();
        protected override void OnHeaderGUI();
        [Obsolete("Use GetMaterialProperty instead.")]
        public float GetFloat(string propertyName, out bool hasMixedValue);
        [Obsolete("Use MaterialProperty instead.")]
        public void SetFloat(string propertyName, float value);
        [Obsolete("Use GetMaterialProperty instead.")]
        public Color GetColor(string propertyName, out bool hasMixedValue);
        [Obsolete("Use MaterialProperty instead.")]
        public void SetColor(string propertyName, Color value);
        [Obsolete("Use GetMaterialProperty instead.")]
        public Vector4 GetVector(string propertyName, out bool hasMixedValue);
        [Obsolete("Use MaterialProperty instead.")]
        public void SetVector(string propertyName, Vector4 value);
        [Obsolete("Use GetMaterialProperty instead.")]
        public Texture GetTexture(string propertyName, out bool hasMixedValue);
        [Obsolete("Use MaterialProperty instead.")]
        public void SetTexture(string propertyName, Texture value);
        [Obsolete("Use MaterialProperty instead.")]
        public Vector2 GetTextureScale(string propertyName, out bool hasMixedValueX, out bool hasMixedValueY);
        [Obsolete("Use MaterialProperty instead.")]
        public Vector2 GetTextureOffset(string propertyName, out bool hasMixedValueX, out bool hasMixedValueY);
        [Obsolete("Use MaterialProperty instead.")]
        public void SetTextureScale(string propertyName, Vector2 value, int coord);
        [Obsolete("Use MaterialProperty instead.")]
        public void SetTextureOffset(string propertyName, Vector2 value, int coord);
        public float RangeProperty(MaterialProperty prop, string label);
        public float RangeProperty(Rect position, MaterialProperty prop, string label);
        public int IntegerProperty(MaterialProperty prop, string label);
        public int IntegerProperty(Rect position, MaterialProperty prop, string label);
        public float FloatProperty(MaterialProperty prop, string label);
        public float FloatProperty(Rect position, MaterialProperty prop, string label);
        public Color ColorProperty(MaterialProperty prop, string label);
        public Color ColorProperty(Rect position, MaterialProperty prop, string label);
        public Vector4 VectorProperty(MaterialProperty prop, string label);
        public Vector4 VectorProperty(MaterialProperty prop, GUIContent label);
        public Vector4 VectorProperty(Rect position, MaterialProperty prop, string label);
        public Vector4 VectorProperty(Rect position, MaterialProperty prop, GUIContent label);
        public void TextureScaleOffsetProperty(MaterialProperty property);
        public float TextureScaleOffsetProperty(Rect position, MaterialProperty property);
        public float TextureScaleOffsetProperty(Rect position, MaterialProperty property, bool partOfTexturePropertyControl);
        public Texture TextureProperty(MaterialProperty prop, string label);
        public Texture TextureProperty(MaterialProperty prop, string label, bool scaleOffset);
        public bool HelpBoxWithButton(GUIContent messageContent, GUIContent buttonContent);
        public void TextureCompatibilityWarning(MaterialProperty prop);
        public Texture TexturePropertyMiniThumbnail(Rect position, MaterialProperty prop, string label, string tooltip);
        public Rect GetTexturePropertyCustomArea(Rect position);
        public Texture TextureProperty(Rect position, MaterialProperty prop, string label);
        public Texture TextureProperty(Rect position, MaterialProperty prop, GUIContent label);
        public Texture TextureProperty(Rect position, MaterialProperty prop, string label, bool scaleOffset);
        public Texture TextureProperty(Rect position, MaterialProperty prop, string label, string tooltip, bool scaleOffset);
        public Texture TextureProperty(Rect position, MaterialProperty prop, GUIContent label, bool scaleOffset);
        public static Vector4 TextureScaleOffsetProperty(Rect position, Vector4 scaleOffset);
        public static Vector4 TextureScaleOffsetProperty(Rect position, Vector4 scaleOffset, bool partOfTexturePropertyControl);
        public float GetPropertyHeight(MaterialProperty prop);
        public float GetPropertyHeight(MaterialProperty prop, string label);
        public static float GetDefaultPropertyHeight(MaterialProperty prop);
        public void BeginAnimatedCheck(Rect totalPosition, MaterialProperty prop);
        public void BeginAnimatedCheck(MaterialProperty prop);
        public void EndAnimatedCheck();
        public void ShaderProperty(MaterialProperty prop, string label);
        public void ShaderProperty(MaterialProperty prop, GUIContent label);
        public void ShaderProperty(MaterialProperty prop, string label, int labelIndent);
        public void ShaderProperty(MaterialProperty prop, GUIContent label, int labelIndent);
        public void ShaderProperty(Rect position, MaterialProperty prop, string label);
        public void ShaderProperty(Rect position, MaterialProperty prop, GUIContent label);
        public void ShaderProperty(Rect position, MaterialProperty prop, string label, int labelIndent);
        public void ShaderProperty(Rect position, MaterialProperty prop, GUIContent label, int labelIndent);
        public void LightmapEmissionProperty();
        public void LightmapEmissionProperty(int labelIndent);
        public void LightmapEmissionProperty(Rect position, int labelIndent);
        public bool EmissionEnabledProperty();
        public static void FixupEmissiveFlag(Material mat);
        public static MaterialGlobalIlluminationFlags FixupEmissiveFlag(Color col, MaterialGlobalIlluminationFlags flags);
        public void LightmapEmissionFlagsProperty(int indent, bool enabled);
        public void LightmapEmissionFlagsProperty(int indent, bool enabled, bool ignoreEmissionColor);
        public void DefaultShaderProperty(MaterialProperty prop, string label);
        public void DefaultShaderProperty(Rect position, MaterialProperty prop, string label);
        [Obsolete("Use RangeProperty with MaterialProperty instead.")]
        public float RangeProperty(string propertyName, string label, float v2, float v3);
        [Obsolete("Use FloatProperty with MaterialProperty instead.")]
        public float FloatProperty(string propertyName, string label);
        [Obsolete("Use ColorProperty with MaterialProperty instead.")]
        public Color ColorProperty(string propertyName, string label);
        [Obsolete("Use VectorProperty with MaterialProperty instead.")]
        public Vector4 VectorProperty(string propertyName, string label);
        [Obsolete("Use TextureProperty with MaterialProperty instead.")]
        public Texture TextureProperty(string propertyName, string label, ShaderUtil.ShaderPropertyTexDim texDim);
        [Obsolete("Use TextureProperty with MaterialProperty instead.")]
        public Texture TextureProperty(string propertyName, string label, ShaderUtil.ShaderPropertyTexDim texDim, bool scaleOffset);
        [Obsolete("Use ShaderProperty that takes MaterialProperty parameter instead.")]
        public void ShaderProperty(Shader shader, int propertyIndex);
        public static MaterialProperty[] GetMaterialProperties(UnityEngine.Object[] mats);
        public static string[] GetMaterialPropertyNames(UnityEngine.Object[] mats);
        public static MaterialProperty GetMaterialProperty(UnityEngine.Object[] mats, string name);
        public static MaterialProperty GetMaterialProperty(UnityEngine.Object[] mats, int propertyIndex);
        public static Renderer PrepareMaterialPropertiesForAnimationMode(MaterialProperty[] properties, bool isMaterialEditable);
        public void SetDefaultGUIWidths();
        public bool PropertiesGUI();
        public void PropertiesDefaultGUI(MaterialProperty[] props);
        public static void ApplyMaterialPropertyDrawers(Material material);
        public static void ApplyMaterialPropertyDrawers(UnityEngine.Object[] targets);
        public void RegisterPropertyChangeUndo(string label);
        public override void OnPreviewSettings();
        public void DefaultPreviewSettingsGUI();
        public sealed override Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height);
        public sealed override bool HasPreviewGUI();
        public override bool RequiresConstantRepaint();
        public override void OnInteractivePreviewGUI(Rect r, GUIStyle background);
        public override void OnPreviewGUI(Rect r, GUIStyle background);
        public void DefaultPreviewGUI(Rect r, GUIStyle background);
        public virtual void OnEnable();
        public virtual void UndoRedoPerformed();
        public virtual void OnDisable();
        public void RenderQueueField();
        public void RenderQueueField(Rect r);
        public bool EnableInstancingField();
        public void EnableInstancingField(Rect r);
        public bool IsInstancingEnabled();
        public bool DoubleSidedGIField();
        public Rect TexturePropertySingleLine(GUIContent label, MaterialProperty textureProp);
        public Rect TexturePropertySingleLine(GUIContent label, MaterialProperty textureProp, MaterialProperty extraProperty1);
        public Rect TexturePropertySingleLine(GUIContent label, MaterialProperty textureProp, MaterialProperty extraProperty1, MaterialProperty extraProperty2);
        [Obsolete("Use TexturePropertyWithHDRColor(GUIContent label, MaterialProperty textureProp, MaterialProperty colorProperty, bool showAlpha)")]
        public Rect TexturePropertyWithHDRColor(GUIContent label, MaterialProperty textureProp, MaterialProperty colorProperty, ColorPickerHDRConfig hdrConfig, bool showAlpha);
        public Rect TexturePropertyWithHDRColor(GUIContent label, MaterialProperty textureProp, MaterialProperty colorProperty, bool showAlpha);
        public Rect TexturePropertyTwoLines(GUIContent label, MaterialProperty textureProp, MaterialProperty extraProperty1, GUIContent label2, MaterialProperty extraProperty2);
        public static Rect GetRightAlignedFieldRect(Rect r);
        public static Rect GetLeftAlignedFieldRect(Rect r);
        public static Rect GetFlexibleRectBetweenLabelAndField(Rect r);
        public static Rect GetFlexibleRectBetweenFieldAndRightEdge(Rect r);
        public static Rect GetRectAfterLabelWidth(Rect r);
    }
}
