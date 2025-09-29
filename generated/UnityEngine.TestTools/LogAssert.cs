#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Text.RegularExpressions;

namespace UnityEngine.TestTools
{
    public static class LogAssert
    {

        public static bool ignoreFailingMessages { get; set; }

        public static void Expect(LogType type, string message);
        public static void Expect(LogType type, Regex message);
        public static void NoUnexpectedReceived();
    }
}
