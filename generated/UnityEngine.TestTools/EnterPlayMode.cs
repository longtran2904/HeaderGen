#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using System.Collections;

namespace UnityEngine.TestTools
{
    public class EnterPlayMode : IEditModeTestYieldInstruction
    {
        public EnterPlayMode(bool expectDomainReload = True);

        public bool ExpectDomainReload { get; }
        public bool ExpectedPlaymodeState { get; }

        public IEnumerator Perform();
    }
}
