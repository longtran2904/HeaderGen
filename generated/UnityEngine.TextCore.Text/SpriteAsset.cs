#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
    [ExcludeFromPreset]
    [HelpURL("https://docs.unity3d.com/2021.3/Documentation/Manual/UIE-sprite.html")]
    public class SpriteAsset : TextAsset
    {
        [SerializeField]
        public List<SpriteAsset> fallbackSpriteAssets;

        public SpriteAsset();

        public FaceInfo faceInfo { get; }
        public Texture spriteSheet { get; }
        public List<SpriteCharacter> spriteCharacterTable { get; }
        public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; }
        public List<SpriteGlyph> spriteGlyphTable { get; }

        public void UpdateLookupTables();
        public int GetSpriteIndexFromHashcode(int hashCode);
        public int GetSpriteIndexFromUnicode(uint unicode);
        public int GetSpriteIndexFromName(string name);
        public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex);
        public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null);
        public void SortGlyphTable();
    }
}
