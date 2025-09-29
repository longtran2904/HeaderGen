#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public class TestRunnerApi : ScriptableObject, ITestRunnerApi
    {
        public TestRunnerApi();

        public string Execute(ExecutionSettings executionSettings);
        public void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        public void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        public void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
