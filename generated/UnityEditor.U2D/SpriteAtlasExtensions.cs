#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.U2D;

namespace UnityEditor.U2D
{
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporterTypes.h")]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporter.bindings.h")]
    [NativeHeader("Editor/Src/2D/SpriteAtlas/SpriteAtlas_EditorTypes.h")]
    [NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
    public static class SpriteAtlasExtensions
    {
        public static void Add([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, UnityEngine.Object[] objects);
        public static void Remove([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, UnityEngine.Object[] objects);
        public static UnityEngine.Object[] GetPackables([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas);
        public static SpriteAtlasTextureSettings GetTextureSettings([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas);
        public static void SetTextureSettings([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, SpriteAtlasTextureSettings src);
        public static SpriteAtlasPackingSettings GetPackingSettings([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas);
        public static void SetPackingSettings([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, SpriteAtlasPackingSettings src);
        public static TextureImporterPlatformSettings GetPlatformSettings([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, string buildTarget);
        public static void SetPlatformSettings([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, TextureImporterPlatformSettings src);
        public static void SetIncludeInBuild([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, bool value);
        public static void SetIsVariant([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, bool value);
        public static void SetMasterAtlas([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, SpriteAtlas value);
        public static void SetVariantScale([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas, float value);
        public static bool IsIncludeInBuild([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas);
        public static SpriteAtlas GetMasterAtlas([NotNull("NullExceptionObject")] this SpriteAtlas spriteAtlas);
    }
}
