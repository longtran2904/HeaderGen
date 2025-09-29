#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public class TMP_GlyphPairAdjustmentRecord
    {
        public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord);

        public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
        public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
        public FontFeatureLookupFlags featureLookupFlags { get; set; }
    }
}
