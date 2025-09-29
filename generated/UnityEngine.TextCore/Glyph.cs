#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
    [UsedByNativeCode]
    public class Glyph
    {

        public Glyph();
        public Glyph(Glyph glyph);
        public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect);
        public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex);

        public uint index { get; set; }
        public GlyphMetrics metrics { get; set; }
        public GlyphRect glyphRect { get; set; }
        public float scale { get; set; }
        public int atlasIndex { get; set; }
        public GlyphClassDefinitionType classDefinitionType { get; set; }

        public bool Compare(Glyph other);
    }
}
