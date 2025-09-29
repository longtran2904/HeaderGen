#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
    [ExcludeFromPreset]
    public class TMP_FontAsset : TMP_Asset
    {
        [SerializeField]
        public Texture2D atlas;
        public float normalStyle;
        public float normalSpacingOffset;
        public float boldStyle;
        public float boldSpacing;
        public byte italicStyle;
        public byte tabSize;

        public TMP_FontAsset();

        public string version { get; }
        public Font sourceFontFile { get; }
        public AtlasPopulationMode atlasPopulationMode { get; set; }
        public FaceInfo faceInfo { get; set; }
        public List<Glyph> glyphTable { get; }
        public Dictionary<uint, Glyph> glyphLookupTable { get; }
        public List<TMP_Character> characterTable { get; }
        public Dictionary<uint, TMP_Character> characterLookupTable { get; }
        public Texture2D atlasTexture { get; }
        public Texture2D[] atlasTextures { get; set; }
        public int atlasTextureCount { get; }
        public bool isMultiAtlasTexturesEnabled { get; set; }
        [Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
        public FaceInfo_Legacy fontInfo { get; }
        public int atlasWidth { get; }
        public int atlasHeight { get; }
        public int atlasPadding { get; }
        public GlyphRenderMode atlasRenderMode { get; }
        public TMP_FontFeatureTable fontFeatureTable { get; }
        public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
        public FontAssetCreationSettings creationSettings { get; set; }
        public TMP_FontWeightPair[] fontWeightTable { get; }

        public static TMP_FontAsset CreateFontAsset(Font font);
        public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = True);
        public void ReadFontAssetDefinition();
        public bool HasCharacter(int character);
        public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False);
        public bool HasCharacters(string text, out List<char> missingCharacters);
        public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False);
        public bool HasCharacters(string text);
        public static string GetCharacters(TMP_FontAsset fontAsset);
        public static int[] GetCharactersArray(TMP_FontAsset fontAsset);
        public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False);
        public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False);
        public bool TryAddCharacters(string characters, bool includeFontFeatures = False);
        public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False);
        public void ClearFontAssetData(bool setAtlasSizeToZero = False);
    }
}
