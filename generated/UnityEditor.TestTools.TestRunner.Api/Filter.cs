#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public class Filter
    {
        [SerializeField]
        public TestMode testMode;
        [SerializeField]
        public string[] testNames;
        [SerializeField]
        public string[] groupNames;
        [SerializeField]
        public string[] categoryNames;
        [SerializeField]
        public string[] assemblyNames;
        [SerializeField]
        public BuildTarget? targetPlatform;

        public Filter();
    }
}
