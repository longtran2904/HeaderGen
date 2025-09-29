#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public struct TMP_GlyphValueRecord
    {
        public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);

        public float xPlacement { get; set; }
        public float yPlacement { get; set; }
        public float xAdvance { get; set; }
        public float yAdvance { get; set; }

        public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b);
    }
}
