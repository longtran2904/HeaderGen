#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public class ExecutionSettings
    {
        public ITestRunSettings overloadTestRunSettings;
        [SerializeField]
        public Filter[] filters;
        [SerializeField]
        public bool runSynchronously;
        [SerializeField]
        public int playerHeartbeatTimeout;

        public ExecutionSettings(params Filter[] filtersToExecute);
    }
}
