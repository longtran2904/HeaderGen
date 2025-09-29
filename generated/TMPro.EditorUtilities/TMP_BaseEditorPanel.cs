#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    public abstract class TMP_BaseEditorPanel : Editor
    {
        protected Dictionary<int, int> m_TextStyleIndexLookup;
        public int selAlignGridA;
        public int selAlignGridB;
        protected SerializedProperty m_TextProp;
        protected SerializedProperty m_IsRightToLeftProp;
        protected string m_RtlText;
        protected SerializedProperty m_FontAssetProp;
        protected SerializedProperty m_FontSharedMaterialProp;
        protected Material[] m_MaterialPresets;
        protected GUIContent[] m_MaterialPresetNames;
        protected Dictionary<int, int> m_MaterialPresetIndexLookup;
        protected int m_MaterialPresetSelectionIndex;
        protected bool m_IsPresetListDirty;
        protected List<TMP_Style> m_Styles;
        protected GUIContent[] m_StyleNames;
        protected int m_StyleSelectionIndex;
        protected SerializedProperty m_FontStyleProp;
        protected SerializedProperty m_FontColorProp;
        protected SerializedProperty m_EnableVertexGradientProp;
        protected SerializedProperty m_FontColorGradientProp;
        protected SerializedProperty m_FontColorGradientPresetProp;
        protected SerializedProperty m_OverrideHtmlColorProp;
        protected SerializedProperty m_FontSizeProp;
        protected SerializedProperty m_FontSizeBaseProp;
        protected SerializedProperty m_AutoSizingProp;
        protected SerializedProperty m_FontSizeMinProp;
        protected SerializedProperty m_FontSizeMaxProp;
        protected SerializedProperty m_LineSpacingMaxProp;
        protected SerializedProperty m_CharWidthMaxAdjProp;
        protected SerializedProperty m_CharacterSpacingProp;
        protected SerializedProperty m_WordSpacingProp;
        protected SerializedProperty m_LineSpacingProp;
        protected SerializedProperty m_ParagraphSpacingProp;
        protected SerializedProperty m_TextAlignmentProp;
        protected SerializedProperty m_HorizontalAlignmentProp;
        protected SerializedProperty m_VerticalAlignmentProp;
        protected SerializedProperty m_HorizontalMappingProp;
        protected SerializedProperty m_VerticalMappingProp;
        protected SerializedProperty m_UvLineOffsetProp;
        protected SerializedProperty m_EnableWordWrappingProp;
        protected SerializedProperty m_WordWrappingRatiosProp;
        protected SerializedProperty m_TextOverflowModeProp;
        protected SerializedProperty m_PageToDisplayProp;
        protected SerializedProperty m_LinkedTextComponentProp;
        protected SerializedProperty m_ParentLinkedTextComponentProp;
        protected SerializedProperty m_EnableKerningProp;
        protected SerializedProperty m_IsRichTextProp;
        protected SerializedProperty m_HasFontAssetChangedProp;
        protected SerializedProperty m_EnableExtraPaddingProp;
        protected SerializedProperty m_CheckPaddingRequiredProp;
        protected SerializedProperty m_EnableEscapeCharacterParsingProp;
        protected SerializedProperty m_UseMaxVisibleDescenderProp;
        protected SerializedProperty m_GeometrySortingOrderProp;
        protected SerializedProperty m_IsTextObjectScaleStaticProp;
        protected SerializedProperty m_SpriteAssetProp;
        protected SerializedProperty m_StyleSheetAssetProp;
        protected SerializedProperty m_TextStyleHashCodeProp;
        protected SerializedProperty m_MarginProp;
        protected SerializedProperty m_ColorModeProp;
        protected bool m_HavePropertiesChanged;
        protected TMP_Text m_TextComponent;
        protected TMP_Text m_PreviousLinkedTextComponent;
        protected RectTransform m_RectTransform;
        protected Material m_TargetMaterial;
        protected Vector3[] m_RectCorners;
        protected Vector3[] m_HandlePoints;
        protected static readonly GUIContent k_ExtraSettingsLabel;
        protected static string[] k_UiStateLabel;
        protected static int s_EventId;

        protected TMP_BaseEditorPanel();

        protected virtual void OnEnable();
        protected virtual void OnDisable();
        public override void OnInspectorGUI();
        public void OnSceneGUI();
        protected void DrawTextInput();
        protected void DrawMainSettings();
        protected abstract void DrawExtraSettings();
        protected void DrawMargins();
        protected void DrawGeometrySorting();
        protected void DrawIsTextObjectScaleStatic();
        protected void DrawRichText();
        protected void DrawParsing();
        protected void DrawSpriteAsset();
        protected void DrawStyleSheet();
        protected void DrawTextureMapping();
        protected void DrawKerning();
        protected void DrawPadding();
        protected GUIContent[] GetMaterialPresets();
        protected GUIContent[] GetStyleNames();
        protected void DrawMarginProperty(SerializedProperty property, GUIContent label);
        protected void DrawPropertySlider(GUIContent label, SerializedProperty property);
        protected abstract bool IsMixSelectionTypes();
        protected abstract void OnUndoRedo();

        protected struct Foldout
        {
            public static bool extraSettings;
            public static bool materialInspector;
        }
    }
}
