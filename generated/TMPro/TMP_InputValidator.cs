#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public abstract class TMP_InputValidator : ScriptableObject
    {

        protected TMP_InputValidator();

        public abstract char Validate(ref string text, ref int pos, char ch);
    }
}
