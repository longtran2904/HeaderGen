#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
    [ExcludeFromPreset]
    public class TMP_SpriteAsset : TMP_Asset
    {

        public Texture spriteSheet;
        public List<TMP_Sprite> spriteInfoList;
        [SerializeField]
        public List<TMP_SpriteAsset> fallbackSpriteAssets;

        public TMP_SpriteAsset();

        public string version { get; }
        public FaceInfo faceInfo { get; }
        public List<TMP_SpriteCharacter> spriteCharacterTable { get; }
        public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; }
        public List<TMP_SpriteGlyph> spriteGlyphTable { get; }

        public void UpdateLookupTables();
        public int GetSpriteIndexFromHashcode(int hashCode);
        public int GetSpriteIndexFromUnicode(uint unicode);
        public int GetSpriteIndexFromName(string name);
        public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex);
        public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex);
        public void SortGlyphTable();
    }
}
