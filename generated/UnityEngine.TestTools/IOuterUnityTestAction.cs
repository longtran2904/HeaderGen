#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using NUnit.Framework.Interfaces;
using System.Collections;

namespace UnityEngine.TestTools
{
    public interface IOuterUnityTestAction
    {
        IEnumerator BeforeTest(ITest test);
        IEnumerator AfterTest(ITest test);
    }
}
