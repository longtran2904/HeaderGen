#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public class TMP_SpriteCharacter : TMP_TextElement
    {

        public TMP_SpriteCharacter();
        public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph);
        public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph);

        public string name { get; set; }
        public int hashCode { get; }
    }
}
