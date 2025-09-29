#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public class MaterialReferenceManager
    {

        public MaterialReferenceManager();

        public static MaterialReferenceManager instance { get; }

        public static void AddFontAsset(TMP_FontAsset fontAsset);
        public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset);
        public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset);
        public static void AddFontMaterial(int hashCode, Material material);
        public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset);
        public bool Contains(TMP_FontAsset font);
        public bool Contains(TMP_SpriteAsset sprite);
        public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset);
        public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset);
        public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset);
        public static bool TryGetMaterial(int hashCode, out Material material);
    }
}
