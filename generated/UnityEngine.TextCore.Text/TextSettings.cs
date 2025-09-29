#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text
{
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    public class TextSettings : ScriptableObject
    {
        [SerializeField]
        protected string m_Version;
        [FormerlySerializedAs("m_defaultFontAsset")]
        [SerializeField]
        protected FontAsset m_DefaultFontAsset;
        [FormerlySerializedAs("m_defaultFontAssetPath")]
        [SerializeField]
        protected string m_DefaultFontAssetPath;
        [FormerlySerializedAs("m_fallbackFontAssets")]
        [SerializeField]
        protected List<FontAsset> m_FallbackFontAssets;
        [FormerlySerializedAs("m_matchMaterialPreset")]
        [SerializeField]
        protected bool m_MatchMaterialPreset;
        [FormerlySerializedAs("m_missingGlyphCharacter")]
        [SerializeField]
        protected int m_MissingCharacterUnicode;
        [SerializeField]
        protected bool m_ClearDynamicDataOnBuild;
        [FormerlySerializedAs("m_defaultSpriteAsset")]
        [SerializeField]
        protected SpriteAsset m_DefaultSpriteAsset;
        [FormerlySerializedAs("m_defaultSpriteAssetPath")]
        [SerializeField]
        protected string m_DefaultSpriteAssetPath;
        [SerializeField]
        protected List<SpriteAsset> m_FallbackSpriteAssets;
        [SerializeField]
        protected uint m_MissingSpriteCharacterUnicode;
        [FormerlySerializedAs("m_defaultStyleSheet")]
        [SerializeField]
        protected TextStyleSheet m_DefaultStyleSheet;
        [SerializeField]
        protected string m_StyleSheetsResourcePath;
        [FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
        [SerializeField]
        protected string m_DefaultColorGradientPresetsPath;
        [SerializeField]
        protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules;
        [FormerlySerializedAs("m_warningsDisabled")]
        [SerializeField]
        protected bool m_DisplayWarnings;

        public TextSettings();

        public string version { get; }
        public FontAsset defaultFontAsset { get; set; }
        public string defaultFontAssetPath { get; set; }
        public List<FontAsset> fallbackFontAssets { get; set; }
        public bool matchMaterialPreset { get; set; }
        public int missingCharacterUnicode { get; set; }
        public bool clearDynamicDataOnBuild { get; set; }
        public SpriteAsset defaultSpriteAsset { get; set; }
        public string defaultSpriteAssetPath { get; set; }
        public List<SpriteAsset> fallbackSpriteAssets { get; set; }
        public uint missingSpriteCharacterUnicode { get; set; }
        public TextStyleSheet defaultStyleSheet { get; set; }
        public string styleSheetsResourcePath { get; set; }
        public string defaultColorGradientPresetsPath { get; set; }
        public UnicodeLineBreakingRules lineBreakingRules { get; set; }
        public bool displayWarnings { get; set; }

        protected void InitializeFontReferenceLookup();
        protected FontAsset GetCachedFontAssetInternal(Font font);
    }
}
