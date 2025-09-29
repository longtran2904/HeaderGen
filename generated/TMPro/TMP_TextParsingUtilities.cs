#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public class TMP_TextParsingUtilities
    {

        public TMP_TextParsingUtilities();

        public static TMP_TextParsingUtilities instance { get; }

        public static int GetHashCode(string s);
        public static int GetHashCodeCaseSensitive(string s);
        public static char ToLowerASCIIFast(char c);
        public static char ToUpperASCIIFast(char c);
        public static uint ToUpperASCIIFast(uint c);
        public static uint ToLowerASCIIFast(uint c);
        public static bool IsHighSurrogate(uint c);
        public static bool IsLowSurrogate(uint c);
    }
}
