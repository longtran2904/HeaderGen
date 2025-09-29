#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace UnityEditor.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class RequirePlatformSupportAttribute : NUnitAttribute, IApplyToTest
    {
        public RequirePlatformSupportAttribute(params BuildTarget[] platforms);

        public BuildTarget[] platforms { get; }
    }
}
