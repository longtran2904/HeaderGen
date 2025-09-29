#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TMPro
{
    public abstract class TMP_Text : MaskableGraphic
    {
        [SerializeField]
        [TextArea(5, 10)]
        protected string m_text;
        [SerializeField]
        protected ITextPreprocessor m_TextPreprocessor;
        [SerializeField]
        protected bool m_isRightToLeft;
        [SerializeField]
        protected TMP_FontAsset m_fontAsset;
        protected TMP_FontAsset m_currentFontAsset;
        protected bool m_isSDFShader;
        [SerializeField]
        protected Material m_sharedMaterial;
        protected Material m_currentMaterial;
        protected int m_currentMaterialIndex;
        [SerializeField]
        protected Material[] m_fontSharedMaterials;
        [SerializeField]
        protected Material m_fontMaterial;
        [SerializeField]
        protected Material[] m_fontMaterials;
        protected bool m_isMaterialDirty;
        [SerializeField]
        protected Color32 m_fontColor32;
        [SerializeField]
        protected Color m_fontColor;
        protected Color32 m_underlineColor;
        protected Color32 m_strikethroughColor;
        [SerializeField]
        protected bool m_enableVertexGradient;
        [SerializeField]
        protected ColorMode m_colorMode;
        [SerializeField]
        protected VertexGradient m_fontColorGradient;
        [SerializeField]
        protected TMP_ColorGradient m_fontColorGradientPreset;
        [SerializeField]
        protected TMP_SpriteAsset m_spriteAsset;
        [SerializeField]
        protected bool m_tintAllSprites;
        protected bool m_tintSprite;
        protected Color32 m_spriteColor;
        [SerializeField]
        protected TMP_StyleSheet m_StyleSheet;
        [SerializeField]
        protected int m_TextStyleHashCode;
        [SerializeField]
        protected bool m_overrideHtmlColors;
        [SerializeField]
        protected Color32 m_faceColor;
        protected Color32 m_outlineColor;
        protected float m_outlineWidth;
        [SerializeField]
        protected float m_fontSize;
        protected float m_currentFontSize;
        [SerializeField]
        protected float m_fontSizeBase;
        protected TMP_TextProcessingStack<float> m_sizeStack;
        [SerializeField]
        protected FontWeight m_fontWeight;
        protected FontWeight m_FontWeightInternal;
        protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack;
        [SerializeField]
        protected bool m_enableAutoSizing;
        protected float m_maxFontSize;
        protected float m_minFontSize;
        protected int m_AutoSizeIterationCount;
        protected int m_AutoSizeMaxIterationCount;
        protected bool m_IsAutoSizePointSizeSet;
        [SerializeField]
        protected float m_fontSizeMin;
        [SerializeField]
        protected float m_fontSizeMax;
        [SerializeField]
        protected FontStyles m_fontStyle;
        protected FontStyles m_FontStyleInternal;
        protected TMP_FontStyleStack m_fontStyleStack;
        protected bool m_isUsingBold;
        [SerializeField]
        protected HorizontalAlignmentOptions m_HorizontalAlignment;
        [SerializeField]
        protected VerticalAlignmentOptions m_VerticalAlignment;
        [FormerlySerializedAs("m_lineJustification")]
        [SerializeField]
        protected TextAlignmentOptions m_textAlignment;
        protected HorizontalAlignmentOptions m_lineJustification;
        protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack;
        protected Vector3[] m_textContainerLocalCorners;
        [SerializeField]
        protected float m_characterSpacing;
        protected float m_cSpacing;
        protected float m_monoSpacing;
        [SerializeField]
        protected float m_wordSpacing;
        [SerializeField]
        protected float m_lineSpacing;
        protected float m_lineSpacingDelta;
        protected float m_lineHeight;
        protected bool m_IsDrivenLineSpacing;
        [SerializeField]
        protected float m_lineSpacingMax;
        [SerializeField]
        protected float m_paragraphSpacing;
        [SerializeField]
        protected float m_charWidthMaxAdj;
        protected float m_charWidthAdjDelta;
        [SerializeField]
        protected bool m_enableWordWrapping;
        protected bool m_isCharacterWrappingEnabled;
        protected bool m_isNonBreakingSpace;
        protected bool m_isIgnoringAlignment;
        [SerializeField]
        protected float m_wordWrappingRatios;
        [SerializeField]
        protected TextOverflowModes m_overflowMode;
        protected int m_firstOverflowCharacterIndex;
        [SerializeField]
        protected TMP_Text m_linkedTextComponent;
        protected bool m_isTextTruncated;
        [SerializeField]
        protected bool m_enableKerning;
        protected float m_GlyphHorizontalAdvanceAdjustment;
        [SerializeField]
        protected bool m_enableExtraPadding;
        [SerializeField]
        protected bool checkPaddingRequired;
        [SerializeField]
        protected bool m_isRichText;
        [SerializeField]
        protected bool m_parseCtrlCharacters;
        protected bool m_isOverlay;
        [SerializeField]
        protected bool m_isOrthographic;
        [SerializeField]
        protected bool m_isCullingEnabled;
        protected bool m_isMaskingEnabled;
        protected bool isMaskUpdateRequired;
        protected bool m_ignoreCulling;
        [SerializeField]
        protected TextureMappingOptions m_horizontalMapping;
        [SerializeField]
        protected TextureMappingOptions m_verticalMapping;
        [SerializeField]
        protected float m_uvLineOffset;
        protected TextRenderFlags m_renderMode;
        [SerializeField]
        protected VertexSortingOrder m_geometrySortingOrder;
        [SerializeField]
        protected bool m_IsTextObjectScaleStatic;
        [SerializeField]
        protected bool m_VertexBufferAutoSizeReduction;
        protected int m_firstVisibleCharacter;
        protected int m_maxVisibleCharacters;
        protected int m_maxVisibleWords;
        protected int m_maxVisibleLines;
        [SerializeField]
        protected bool m_useMaxVisibleDescender;
        [SerializeField]
        protected int m_pageToDisplay;
        protected bool m_isNewPage;
        [SerializeField]
        protected Vector4 m_margin;
        protected float m_marginLeft;
        protected float m_marginRight;
        protected float m_marginWidth;
        protected float m_marginHeight;
        protected float m_width;
        protected TMP_TextInfo m_textInfo;
        protected bool m_havePropertiesChanged;
        [SerializeField]
        protected bool m_isUsingLegacyAnimationComponent;
        protected Transform m_transform;
        protected RectTransform m_rectTransform;
        protected Vector2 m_PreviousRectTransformSize;
        protected Vector2 m_PreviousPivotPosition;
        protected bool m_autoSizeTextContainer;
        protected Mesh m_mesh;
        [SerializeField]
        protected bool m_isVolumetricText;
        protected TMP_SpriteAnimator m_spriteAnimator;
        protected float m_flexibleHeight;
        protected float m_flexibleWidth;
        protected float m_minWidth;
        protected float m_minHeight;
        protected float m_maxWidth;
        protected float m_maxHeight;
        protected LayoutElement m_LayoutElement;
        protected float m_preferredWidth;
        protected float m_renderedWidth;
        protected bool m_isPreferredWidthDirty;
        protected float m_preferredHeight;
        protected float m_renderedHeight;
        protected bool m_isPreferredHeightDirty;
        protected bool m_isCalculatingPreferredValues;
        protected int m_layoutPriority;
        protected bool m_isLayoutDirty;
        protected bool m_isAwake;
        protected float m_fontScaleMultiplier;
        protected float tag_LineIndent;
        protected float tag_Indent;
        protected TMP_TextProcessingStack<float> m_indentStack;
        protected bool tag_NoParsing;
        protected bool m_isParsingText;
        protected Matrix4x4 m_FXMatrix;
        protected bool m_isFXMatrixSet;
        protected int m_totalCharacterCount;
        protected int m_characterCount;
        protected int m_firstCharacterOfLine;
        protected int m_firstVisibleCharacterOfLine;
        protected int m_lastCharacterOfLine;
        protected int m_lastVisibleCharacterOfLine;
        protected int m_lineNumber;
        protected int m_lineVisibleCharacterCount;
        protected int m_pageNumber;
        protected float m_PageAscender;
        protected float m_maxTextAscender;
        protected float m_maxCapHeight;
        protected float m_ElementAscender;
        protected float m_ElementDescender;
        protected float m_maxLineAscender;
        protected float m_maxLineDescender;
        protected float m_startOfLineAscender;
        protected float m_startOfLineDescender;
        protected float m_lineOffset;
        protected Extents m_meshExtents;
        protected Color32 m_htmlColor;
        protected TMP_TextProcessingStack<Color32> m_colorStack;
        protected TMP_TextProcessingStack<Color32> m_underlineColorStack;
        protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack;
        protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack;
        protected TMP_ColorGradient m_colorGradientPreset;
        protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack;
        protected bool m_colorGradientPresetIsTinted;
        protected float m_tabSpacing;
        protected float m_spacing;
        protected TMP_TextProcessingStack<int>[] m_TextStyleStacks;
        protected int m_TextStyleStackDepth;
        protected TMP_TextProcessingStack<int> m_ItalicAngleStack;
        protected int m_ItalicAngle;
        protected TMP_TextProcessingStack<int> m_actionStack;
        protected float m_padding;
        protected float m_baselineOffset;
        protected TMP_TextProcessingStack<float> m_baselineOffsetStack;
        protected float m_xAdvance;
        protected TMP_TextElementType m_textElementType;
        protected TMP_TextElement m_cached_TextElement;
        protected SpecialCharacter m_Ellipsis;
        protected SpecialCharacter m_Underline;
        protected TMP_SpriteAsset m_defaultSpriteAsset;
        protected TMP_SpriteAsset m_currentSpriteAsset;
        protected int m_spriteCount;
        protected int m_spriteIndex;
        protected int m_spriteAnimationID;
        protected bool m_ignoreActiveState;
        protected static MaterialReference[] m_materialReferences;
        protected static Dictionary<int, int> m_materialReferenceIndexLookup;
        protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack;
        protected static Color32 s_colorWhite;
        protected static WordWrapState m_SavedWordWrapState;
        protected static WordWrapState m_SavedLineState;
        protected static WordWrapState m_SavedEllipsisState;
        protected static WordWrapState m_SavedLastValidState;
        protected static WordWrapState m_SavedSoftLineBreakState;
        protected static Vector2 k_LargePositiveVector2;
        protected static Vector2 k_LargeNegativeVector2;
        protected static float k_LargePositiveFloat;
        protected static float k_LargeNegativeFloat;
        protected static int k_LargePositiveInt;
        protected static int k_LargeNegativeInt;

        protected TMP_Text();

        public virtual string text { get; set; }
        public ITextPreprocessor textPreprocessor { get; set; }
        public bool isRightToLeftText { get; set; }
        public TMP_FontAsset font { get; set; }
        public virtual Material fontSharedMaterial { get; set; }
        public virtual Material[] fontSharedMaterials { get; set; }
        public Material fontMaterial { get; set; }
        public virtual Material[] fontMaterials { get; set; }
        public override Color color { get; set; }
        public float alpha { get; set; }
        public bool enableVertexGradient { get; set; }
        public VertexGradient colorGradient { get; set; }
        public TMP_ColorGradient colorGradientPreset { get; set; }
        public TMP_SpriteAsset spriteAsset { get; set; }
        public bool tintAllSprites { get; set; }
        public TMP_StyleSheet styleSheet { get; set; }
        public TMP_Style textStyle { get; set; }
        public bool overrideColorTags { get; set; }
        public Color32 faceColor { get; set; }
        public Color32 outlineColor { get; set; }
        public float outlineWidth { get; set; }
        public float fontSize { get; set; }
        public FontWeight fontWeight { get; set; }
        public float pixelsPerUnit { get; }
        public bool enableAutoSizing { get; set; }
        public float fontSizeMin { get; set; }
        public float fontSizeMax { get; set; }
        public FontStyles fontStyle { get; set; }
        public bool isUsingBold { get; }
        public HorizontalAlignmentOptions horizontalAlignment { get; set; }
        public VerticalAlignmentOptions verticalAlignment { get; set; }
        public TextAlignmentOptions alignment { get; set; }
        public float characterSpacing { get; set; }
        public float wordSpacing { get; set; }
        public float lineSpacing { get; set; }
        public float lineSpacingAdjustment { get; set; }
        public float paragraphSpacing { get; set; }
        public float characterWidthAdjustment { get; set; }
        public bool enableWordWrapping { get; set; }
        public float wordWrappingRatios { get; set; }
        public TextOverflowModes overflowMode { get; set; }
        public bool isTextOverflowing { get; }
        public int firstOverflowCharacterIndex { get; }
        public TMP_Text linkedTextComponent { get; set; }
        public bool isTextTruncated { get; }
        public bool enableKerning { get; set; }
        public bool extraPadding { get; set; }
        public bool richText { get; set; }
        public bool parseCtrlCharacters { get; set; }
        public bool isOverlay { get; set; }
        public bool isOrthographic { get; set; }
        public bool enableCulling { get; set; }
        public bool ignoreVisibility { get; set; }
        public TextureMappingOptions horizontalMapping { get; set; }
        public TextureMappingOptions verticalMapping { get; set; }
        public float mappingUvLineOffset { get; set; }
        public TextRenderFlags renderMode { get; set; }
        public VertexSortingOrder geometrySortingOrder { get; set; }
        public bool isTextObjectScaleStatic { get; set; }
        public bool vertexBufferAutoSizeReduction { get; set; }
        public int firstVisibleCharacter { get; set; }
        public int maxVisibleCharacters { get; set; }
        public int maxVisibleWords { get; set; }
        public int maxVisibleLines { get; set; }
        public bool useMaxVisibleDescender { get; set; }
        public int pageToDisplay { get; set; }
        public virtual Vector4 margin { get; set; }
        public TMP_TextInfo textInfo { get; }
        public bool havePropertiesChanged { get; set; }
        public bool isUsingLegacyAnimationComponent { get; set; }
        public Transform transform { get; }
        public RectTransform rectTransform { get; }
        public virtual bool autoSizeTextContainer { get; set; }
        public virtual Mesh mesh { get; }
        public bool isVolumetricText { get; set; }
        public Bounds bounds { get; }
        public Bounds textBounds { get; }
        protected TMP_SpriteAnimator spriteAnimator { get; }
        public float flexibleHeight { get; }
        public float flexibleWidth { get; }
        public float minWidth { get; }
        public float minHeight { get; }
        public float maxWidth { get; }
        public float maxHeight { get; }
        protected LayoutElement layoutElement { get; }
        public virtual float preferredWidth { get; }
        public virtual float preferredHeight { get; }
        public virtual float renderedWidth { get; }
        public virtual float renderedHeight { get; }
        public int layoutPriority { get; }

        public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest;
        public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest;
        public virtual event Action<TMP_TextInfo> OnPreRenderText;

        protected virtual void LoadFontAsset();
        protected virtual void SetSharedMaterial(Material mat);
        protected virtual Material GetMaterial(Material mat);
        protected virtual void SetFontBaseMaterial(Material mat);
        protected virtual Material[] GetSharedMaterials();
        protected virtual void SetSharedMaterials(Material[] materials);
        protected virtual Material[] GetMaterials(Material[] mats);
        protected virtual Material CreateMaterialInstance(Material source);
        protected void SetVertexColorGradient(TMP_ColorGradient gradient);
        protected void SetTextSortingOrder(VertexSortingOrder order);
        protected void SetTextSortingOrder(int[] order);
        protected virtual void SetFaceColor(Color32 color);
        protected virtual void SetOutlineColor(Color32 color);
        protected virtual void SetOutlineThickness(float thickness);
        protected virtual void SetShaderDepth();
        protected virtual void SetCulling();
        protected virtual float GetPaddingForMaterial();
        protected virtual float GetPaddingForMaterial(Material mat);
        protected virtual Vector3[] GetTextContainerLocalCorners();
        public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False);
        public virtual void UpdateGeometry(Mesh mesh, int index);
        public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags);
        public virtual void UpdateVertexData();
        public virtual void SetVertices(Vector3[] vertices);
        public virtual void UpdateMeshPadding();
        public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        protected void ParseInputText();
        public void SetText(string sourceText, bool syncTextInputBox = True);
        public void SetText(string sourceText, float arg0);
        public void SetText(string sourceText, float arg0, float arg1);
        public void SetText(string sourceText, float arg0, float arg1, float arg2);
        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3);
        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4);
        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);
        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);
        public void SetText(StringBuilder sourceText);
        public void SetText(char[] sourceText);
        public void SetText(char[] sourceText, int start, int length);
        public void SetCharArray(char[] sourceText);
        public void SetCharArray(char[] sourceText, int start, int length);
        public Vector2 GetPreferredValues();
        public Vector2 GetPreferredValues(float width, float height);
        public Vector2 GetPreferredValues(string text);
        public Vector2 GetPreferredValues(string text, float width, float height);
        protected float GetPreferredWidth();
        protected float GetPreferredHeight();
        public Vector2 GetRenderedValues();
        public Vector2 GetRenderedValues(bool onlyVisibleCharacters);
        protected float GetRenderedWidth(bool onlyVisibleCharacters);
        protected float GetRenderedHeight(bool onlyVisibleCharacters);
        protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled);
        protected virtual Bounds GetCompoundBounds();
        protected Bounds GetTextBounds();
        protected Bounds GetTextBounds(bool onlyVisibleCharacters);
        protected void AdjustLineOffset(int startIndex, int endIndex, float offset);
        protected void ResizeLineExtents(int size);
        public virtual TMP_TextInfo GetTextInfo(string text);
        public virtual void ComputeMarginSize();
        protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender);
        protected void SaveWordWrappingState(ref WordWrapState state, int index, int count);
        protected int RestoreWordWrappingState(ref WordWrapState state);
        protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor);
        protected virtual void SaveSpriteVertexInfo(Color32 vertexColor);
        protected virtual void FillCharacterVertexBuffers(int i, int index_X4);
        protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric);
        protected virtual void FillSpriteVertexBuffers(int i, int index_X4);
        protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor);
        protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor);
        protected void LoadDefaultSettings();
        protected void GetSpecialCharacters(TMP_FontAsset fontAsset);
        protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset);
        protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset);
        protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c);
        protected TMP_FontAsset GetFontAssetForWeight(int fontWeight);
        protected virtual void SetActiveSubMeshes(bool state);
        protected virtual void DestroySubMeshObjects();
        public virtual void ClearMesh();
        public virtual void ClearMesh(bool uploadGeometry);
        public virtual string GetParsedText();
        protected Vector2 PackUV(float x, float y, float scale);
        protected float PackUV(float x, float y);
        protected int HexToInt(char hex);
        protected int GetUTF16(string text, int i);
        protected int GetUTF16(int[] text, int i);
        protected int GetUTF16(StringBuilder text, int i);
        protected int GetUTF32(string text, int i);
        protected int GetUTF32(int[] text, int i);
        protected int GetUTF32(StringBuilder text, int i);
        protected Color32 HexCharsToColor(char[] hexChars, int tagCount);
        protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
        protected float ConvertToFloat(char[] chars, int startIndex, int length);
        protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex);

        protected struct CharacterSubstitution
        {
            public int index;
            public uint unicode;

            public CharacterSubstitution(int index, uint unicode);
        }
        protected struct SpecialCharacter
        {
            public TMP_Character character;
            public TMP_FontAsset fontAsset;
            public Material material;
            public int materialIndex;

            public SpecialCharacter(TMP_Character character, int materialIndex);
        }
    }
}
