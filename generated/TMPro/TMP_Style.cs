#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public class TMP_Style
    {

        public static TMP_Style NormalStyle { get; }
        public string name { get; set; }
        public int hashCode { get; set; }
        public string styleOpeningDefinition { get; }
        public string styleClosingDefinition { get; }
        public int[] styleOpeningTagArray { get; }
        public int[] styleClosingTagArray { get; }

        public void RefreshStyle();
    }
}
