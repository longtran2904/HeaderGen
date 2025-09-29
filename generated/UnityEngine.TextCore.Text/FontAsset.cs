#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
    [ExcludeFromPreset]
    public class FontAsset : TextAsset
    {
        public FontAsset();

        public Font sourceFontFile { get; }
        public AtlasPopulationMode atlasPopulationMode { get; set; }
        public FaceInfo faceInfo { get; set; }
        public FontWeightPair[] fontWeightTable { get; }
        public List<Glyph> glyphTable { get; }
        public Dictionary<uint, Glyph> glyphLookupTable { get; }
        public List<Character> characterTable { get; }
        public Dictionary<uint, Character> characterLookupTable { get; }
        public Texture2D atlasTexture { get; }
        public Texture2D[] atlasTextures { get; set; }
        public int atlasTextureCount { get; }
        public bool isMultiAtlasTexturesEnabled { get; set; }
        public int atlasWidth { get; }
        public int atlasHeight { get; }
        public int atlasPadding { get; }
        public GlyphRenderMode atlasRenderMode { get; }
        public FontFeatureTable fontFeatureTable { get; }
        public List<FontAsset> fallbackFontAssetTable { get; set; }
        public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
        public float regularStyleWeight { get; set; }
        public float regularStyleSpacing { get; set; }
        public float boldStyleWeight { get; set; }
        public float boldStyleSpacing { get; set; }
        public byte italicStyleSlant { get; set; }
        public byte tabMultiple { get; set; }

        public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90);
        public static FontAsset CreateFontAsset(Font font);
        public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = True);
        public void ReadFontAssetDefinition();
        public bool HasCharacter(int character);
        public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False);
        public bool HasCharacters(string text, out List<char> missingCharacters);
        public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False);
        public bool HasCharacters(string text);
        public static string GetCharacters(FontAsset fontAsset);
        public static int[] GetCharactersArray(FontAsset fontAsset);
        public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False);
        public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False);
        public bool TryAddCharacters(string characters, bool includeFontFeatures = False);
        public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False);
        public void ClearFontAssetData(bool setAtlasSizeToZero = False);
    }
}
