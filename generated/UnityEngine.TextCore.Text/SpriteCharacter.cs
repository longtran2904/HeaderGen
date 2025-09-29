#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

namespace UnityEngine.TextCore.Text
{
    public class SpriteCharacter : TextElement
    {

        public SpriteCharacter();
        public SpriteCharacter(uint unicode, SpriteGlyph glyph);
        public SpriteCharacter(uint unicode, SpriteAsset spriteAsset, SpriteGlyph glyph);

        public string name { get; set; }
        public int hashCode { get; }
    }
}
