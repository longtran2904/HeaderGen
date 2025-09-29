#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporterUtils.h")]
    [NativeHeader("Editor/Src/EditorUserBuildSettings.h")]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporter.deprecated.h")]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporter.h")]
    public sealed class TextureImporter : AssetImporter
    {
        public TextureImporter();

        [Obsolete("textureFormat is no longer accessible at the TextureImporter level. For old 'simple' formats use the textureCompression property for the equivalent automatic choice (Uncompressed for TrueColor, Compressed and HQCommpressed for 16 bits). For platform specific formats use the [[PlatformTextureSettings]] API. Using this setter will setup various parameters to match the new automatic system as well as possible. Getter will return the last value set.")]
        public TextureImporterFormat textureFormat { get; set; }
        public int maxTextureSize { get; set; }
        [NativeProperty("TextureCompressionQuality", False, TargetType.Function)]
        public int compressionQuality { get; set; }
        public bool crunchedCompression { get; set; }
        public bool allowAlphaSplitting { get; set; }
        public AndroidETC2FallbackOverride androidETC2FallbackOverride { get; set; }
        public TextureImporterCompression textureCompression { get; set; }
        public TextureImporterAlphaSource alphaSource { get; set; }
        [Obsolete("Use UnityEditor.TextureImporter.alphaSource instead.")]
        public bool grayscaleToAlpha { get; set; }
        public TextureImporterGenerateCubemap generateCubemap { get; set; }
        [NativeProperty("NPOTScale")]
        public TextureImporterNPOTScale npotScale { get; set; }
        public bool isReadable { get; set; }
        [NativeConditional("ENABLE_TEXTURE_STREAMING")]
        public bool streamingMipmaps { get; set; }
        [NativeConditional("ENABLE_TEXTURE_STREAMING")]
        public int streamingMipmapsPriority { get; set; }
        [NativeConditional("ENABLE_VIRTUALTEXTURING")]
        [NativeProperty("VTOnly")]
        public bool vtOnly { get; set; }
        public bool mipmapEnabled { get; set; }
        public bool borderMipmap { get; set; }
        [NativeProperty("sRGBTexture")]
        public bool sRGBTexture { get; set; }
        public bool mipMapsPreserveCoverage { get; set; }
        public float alphaTestReferenceValue { get; set; }
        [NativeProperty("MipmapMode")]
        public TextureImporterMipFilter mipmapFilter { get; set; }
        public bool fadeout { get; set; }
        public int mipmapFadeDistanceStart { get; set; }
        public int mipmapFadeDistanceEnd { get; set; }
        [Obsolete("generateMipsInLinearSpace Property deprecated. Mipmaps are always generated in linear space.")]
        public bool generateMipsInLinearSpace { get; set; }
        [Obsolete("correctGamma Property deprecated. Mipmaps are always generated in linear space.")]
        public bool correctGamma { get; set; }
        [Obsolete("linearTexture Property deprecated. Use sRGBTexture instead.")]
        public bool linearTexture { get; set; }
        [Obsolete("normalmap Property deprecated. Check [[TextureImporterSettings.textureType]] instead. Getter will work as expected. Setter will set textureType to NormalMap if true, nothing otherwise.")]
        public bool normalmap { get; set; }
        [Obsolete("lightmap Property deprecated. Check [[TextureImporterSettings.textureType]] instead. Getter will work as expected. Setter will set textureType to Lightmap if true, nothing otherwise.")]
        public bool lightmap { get; set; }
        public bool convertToNormalmap { get; set; }
        public TextureImporterNormalFilter normalmapFilter { get; set; }
        [NativeProperty("NormalmapHeightScale")]
        public float heightmapScale { get; set; }
        public int anisoLevel { get; set; }
        public FilterMode filterMode { get; set; }
        public TextureWrapMode wrapMode { get; set; }
        [NativeProperty("WrapU")]
        public TextureWrapMode wrapModeU { get; set; }
        [NativeProperty("WrapV")]
        public TextureWrapMode wrapModeV { get; set; }
        [NativeProperty("WrapW")]
        public TextureWrapMode wrapModeW { get; set; }
        public float mipMapBias { get; set; }
        public bool alphaIsTransparency { get; set; }
        public bool qualifiesForSpritePacking { get; }
        [NativeProperty("SpriteMode")]
        public SpriteImportMode spriteImportMode { get; set; }
        [NativeProperty("SpriteMetaDatas")]
        public SpriteMetaData[] spritesheet { get; set; }
        public SecondarySpriteTexture[] secondarySpriteTextures { get; set; }
        public string spritePackingTag { get; set; }
        [NativeProperty("SpritePixelsToUnits")]
        public float spritePixelsPerUnit { get; set; }
        [Obsolete("Use spritePixelsPerUnit property instead.")]
        public float spritePixelsToUnits { get; set; }
        public Vector2 spritePivot { get; set; }
        public Vector4 spriteBorder { get; set; }
        public TextureImporterType textureType { get; set; }
        public TextureImporterShape textureShape { get; set; }
        public bool ignorePngGamma { get; set; }

        [NativeMethod(HasExplicitThis = True)]
        [Obsolete("Use UnityEditor.TextureImporter.GetPlatformTextureSettings() instead.")]
        public bool GetAllowsAlphaSplitting();
        [NativeMethod(HasExplicitThis = True)]
        [Obsolete("Use UnityEditor.TextureImporter.SetPlatformTextureSettings() instead.")]
        public void SetAllowsAlphaSplitting(bool flag);
        public bool GetPlatformTextureSettings(string platform, out int maxTextureSize, out TextureImporterFormat textureFormat, out int compressionQuality, out bool etc1AlphaSplitEnabled);
        public bool GetPlatformTextureSettings(string platform, out int maxTextureSize, out TextureImporterFormat textureFormat, out int compressionQuality);
        public bool GetPlatformTextureSettings(string platform, out int maxTextureSize, out TextureImporterFormat textureFormat);
        public TextureImporterPlatformSettings GetPlatformTextureSettings(string platform);
        public TextureImporterPlatformSettings GetDefaultPlatformTextureSettings();
        public TextureImporterFormat GetAutomaticFormat(string platform);
        [Obsolete("Use UnityEditor.TextureImporter.SetPlatformTextureSettings(TextureImporterPlatformSettings) instead.")]
        public void SetPlatformTextureSettings(string platform, int maxTextureSize, TextureImporterFormat textureFormat, int compressionQuality, bool allowsAlphaSplit);
        [Obsolete("Use UnityEditor.TextureImporter.SetPlatformTextureSettings(TextureImporterPlatformSettings) instead.")]
        public void SetPlatformTextureSettings(string platform, int maxTextureSize, TextureImporterFormat textureFormat);
        [Obsolete("Use UnityEditor.TextureImporter.SetPlatformTextureSettings(TextureImporterPlatformSettings) instead.")]
        public void SetPlatformTextureSettings(string platform, int maxTextureSize, TextureImporterFormat textureFormat, [DefaultValue(False)] bool allowsAlphaSplit);
        public void SetPlatformTextureSettings(TextureImporterPlatformSettings platformSettings);
        public void ClearPlatformTextureSettings(string platform);
        [RequiredByNativeCode]
        public static bool IsPlatformTextureFormatValid(TextureImporterType textureType, BuildTarget target, TextureImporterFormat currentFormat);
        [RequiredByNativeCode]
        public static bool IsDefaultPlatformTextureFormatValid(TextureImporterType textureType, TextureImporterFormat currentFormat);
        public void GetSourceTextureWidthAndHeight(out int width, out int height);
        public bool DoesSourceTextureHaveAlpha();
        [Obsolete("DoesSourceTextureHaveColor always returns true in Unity.")]
        public bool DoesSourceTextureHaveColor();
        public void ReadTextureSettings(TextureImporterSettings dest);
        public void SetTextureSettings(TextureImporterSettings src);
        public void ReadTextureImportInstructions(BuildTarget target, out TextureFormat desiredFormat, out ColorSpace colorSpace, out int compressionQuality);
    }
}
