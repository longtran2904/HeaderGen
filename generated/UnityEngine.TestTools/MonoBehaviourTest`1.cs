#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

namespace UnityEngine.TestTools
{
    public class MonoBehaviourTest<T> : CustomYieldInstruction where T : MonoBehaviour, IMonoBehaviourTest
    {
        public MonoBehaviourTest(bool dontDestroyOnLoad = True);

        public T component { get; }
        public GameObject gameObject { get; }
        public override bool keepWaiting { get; }
    }
}
