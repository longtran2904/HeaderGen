#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
    [ExcludeFromPreset]
    public class TMP_Settings : ScriptableObject
    {
        public TMP_Settings();

        public static string version { get; }
        public static bool enableWordWrapping { get; }
        public static bool enableKerning { get; }
        public static bool enableExtraPadding { get; }
        public static bool enableTintAllSprites { get; }
        public static bool enableParseEscapeCharacters { get; }
        public static bool enableRaycastTarget { get; }
        public static bool getFontFeaturesAtRuntime { get; }
        public static int missingGlyphCharacter { get; set; }
        public static bool warningsDisabled { get; }
        public static TMP_FontAsset defaultFontAsset { get; }
        public static string defaultFontAssetPath { get; }
        public static float defaultFontSize { get; }
        public static float defaultTextAutoSizingMinRatio { get; }
        public static float defaultTextAutoSizingMaxRatio { get; }
        public static Vector2 defaultTextMeshProTextContainerSize { get; }
        public static Vector2 defaultTextMeshProUITextContainerSize { get; }
        public static bool autoSizeTextContainer { get; }
        public static bool isTextObjectScaleStatic { get; set; }
        public static List<TMP_FontAsset> fallbackFontAssets { get; }
        public static bool matchMaterialPreset { get; }
        public static TMP_SpriteAsset defaultSpriteAsset { get; }
        public static string defaultSpriteAssetPath { get; }
        public static bool enableEmojiSupport { get; set; }
        public static uint missingCharacterSpriteUnicode { get; set; }
        public static string defaultColorGradientPresetsPath { get; }
        public static TMP_StyleSheet defaultStyleSheet { get; }
        public static string styleSheetsResourcePath { get; }
        public static TextAsset leadingCharacters { get; }
        public static TextAsset followingCharacters { get; }
        public static LineBreakingTable linebreakingRules { get; }
        public static bool useModernHangulLineBreakingRules { get; set; }
        public static TMP_Settings instance { get; }

        public static TMP_Settings LoadDefaultSettings();
        public static TMP_Settings GetSettings();
        public static TMP_FontAsset GetFontAsset();
        public static TMP_SpriteAsset GetSpriteAsset();
        public static TMP_StyleSheet GetStyleSheet();
        public static void LoadLinebreakingRules();

        public class LineBreakingTable
        {
            public Dictionary<int, char> leadingCharacters;
            public Dictionary<int, char> followingCharacters;

            public LineBreakingTable();
        }
    }
}
