#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System.Collections.Generic;

namespace TMPro
{
    public class KerningTable
    {

        public List<KerningPair> kerningPairs;

        public KerningTable();

        public void AddKerningPair();
        public int AddKerningPair(uint first, uint second, float offset);
        public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments);
        public void RemoveKerningPair(int left, int right);
        public void RemoveKerningPair(int index);
        public void SortKerningPairs();
    }
}
