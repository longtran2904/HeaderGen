#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine.Serialization;

namespace TMPro
{
    public class KerningPair
    {
        [FormerlySerializedAs("XadvanceOffset")]
        public float xOffset;

        public KerningPair();
        public KerningPair(uint left, uint right, float offset);
        public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments);

        public uint firstGlyph { get; set; }
        public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
        public uint secondGlyph { get; set; }
        public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
        public bool ignoreSpacingAdjustments { get; }
    }
}
