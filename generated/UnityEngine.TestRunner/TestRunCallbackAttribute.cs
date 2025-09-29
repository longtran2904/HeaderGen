#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System;

namespace UnityEngine.TestRunner
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class TestRunCallbackAttribute : Attribute
    {

        public TestRunCallbackAttribute(Type type);
    }
}
