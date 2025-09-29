#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeAsStruct]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporter.bindings.h")]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporterTypes.h")]
    [NativeType(CodegenOptions.Custom, "TextureImporterSettings")]
    public sealed class TextureImporterSettings
    {
        public TextureImporterSettings();

        public TextureImporterType textureType { get; set; }
        public TextureImporterShape textureShape { get; set; }
        public TextureImporterMipFilter mipmapFilter { get; set; }
        public bool mipmapEnabled { get; set; }
        [Obsolete("Texture mips are now always generated in linear space")]
        public bool generateMipsInLinearSpace { get; set; }
        public bool sRGBTexture { get; set; }
        public bool fadeOut { get; set; }
        public bool borderMipmap { get; set; }
        public bool mipMapsPreserveCoverage { get; set; }
        public float alphaTestReferenceValue { get; set; }
        public int mipmapFadeDistanceStart { get; set; }
        public int mipmapFadeDistanceEnd { get; set; }
        public bool convertToNormalMap { get; set; }
        public float heightmapScale { get; set; }
        public TextureImporterNormalFilter normalMapFilter { get; set; }
        public TextureImporterAlphaSource alphaSource { get; set; }
        public TextureImporterSingleChannelComponent singleChannelComponent { get; set; }
        public int flipbookRows { get; set; }
        public int flipbookColumns { get; set; }
        public bool readable { get; set; }
        public bool streamingMipmaps { get; set; }
        public int streamingMipmapsPriority { get; set; }
        public bool vtOnly { get; set; }
        public TextureImporterNPOTScale npotScale { get; set; }
        public TextureImporterGenerateCubemap generateCubemap { get; set; }
        public TextureImporterCubemapConvolution cubemapConvolution { get; set; }
        public bool seamlessCubemap { get; set; }
        public FilterMode filterMode { get; set; }
        public int aniso { get; set; }
        public float mipmapBias { get; set; }
        public TextureWrapMode wrapMode { get; set; }
        public TextureWrapMode wrapModeU { get; set; }
        public TextureWrapMode wrapModeV { get; set; }
        public TextureWrapMode wrapModeW { get; set; }
        public bool alphaIsTransparency { get; set; }
        public bool ignorePngGamma { get; set; }
        public int spriteMode { get; set; }
        public float spritePixelsPerUnit { get; set; }
        [Obsolete("Use spritePixelsPerUnit property instead.")]
        public float spritePixelsToUnits { get; set; }
        public float spriteTessellationDetail { get; set; }
        public uint spriteExtrude { get; set; }
        public SpriteMeshType spriteMeshType { get; set; }
        public int spriteAlignment { get; set; }
        public Vector2 spritePivot { get; set; }
        public Vector4 spriteBorder { get; set; }
        public bool spriteGenerateFallbackPhysicsShape { get; set; }
        [Obsolete("Use sRGBTexture instead")]
        public bool linearTexture { get; set; }
        [Obsolete("Check importer.textureType against TextureImporterType.NormalMap instead. Getter will work as expected. Setter will set textureType to NormalMap if true, nothing otherwise")]
        public bool normalMap { get; set; }
        [Obsolete("Texture format can only be overridden on a per platform basis. See [[TextureImporterPlatformSettings]]")]
        public TextureImporterFormat textureFormat { get; set; }
        [Obsolete("Texture max size can only be overridden on a per platform basis. See [[TextureImporter.maxTextureSize]] for Default platform or [[TextureImporterPlatformSettings]]")]
        public int maxTextureSize { get; set; }
        [Obsolete("Check importer.textureType against TextureImporterType.Lightmap instead. Getter will work as expected. Setter will set textureType to Lightmap if true, nothing otherwise.")]
        public bool lightmap { get; set; }
        [Obsolete("RGBM is no longer a user's choice but has become an implementation detail hidden to the user.")]
        public TextureImporterRGBMMode rgbm { get; set; }
        [Obsolete("Use UnityEditor.TextureImporter.alphaSource instead")]
        public bool grayscaleToAlpha { get; set; }
        [Obsolete("Not used anymore. The right values are automatically picked by the importer.")]
        public int cubemapConvolutionSteps { get; set; }
        [Obsolete("Not used anymore. The right values are automatically picked by the importer.")]
        public float cubemapConvolutionExponent { get; set; }
        [Obsolete("Texture compression can only be overridden on a per platform basis. See [[TextureImporter.compressionQuality]] for Default platform or [[TextureImporterPlatformSettings]]")]
        public int compressionQuality { get; set; }

        [FreeFunction("TextureImporterBindings::Equal")]
        public static bool Equal(TextureImporterSettings a, TextureImporterSettings b);
        public void CopyTo(TextureImporterSettings target);
        [Obsolete("ApplyTextureType(TextureImporterType, bool) is deprecated, use ApplyTextureType(TextureImporterType)")]
        public void ApplyTextureType(TextureImporterType type, bool applyAll);
        public void ApplyTextureType(TextureImporterType type);
    }
}
