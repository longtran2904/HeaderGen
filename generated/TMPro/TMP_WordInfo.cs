#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public struct TMP_WordInfo
    {
        public TMP_Text textComponent;
        public int firstCharacterIndex;
        public int lastCharacterIndex;
        public int characterCount;

        public string GetWord();
    }
}
