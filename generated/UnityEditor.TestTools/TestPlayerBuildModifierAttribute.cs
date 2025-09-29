#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using System;

namespace UnityEditor.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class TestPlayerBuildModifierAttribute : Attribute
    {

        public TestPlayerBuildModifierAttribute(Type type);
    }
}
