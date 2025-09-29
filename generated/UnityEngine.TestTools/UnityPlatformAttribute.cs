#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = True)]
    public class UnityPlatformAttribute : NUnitAttribute, IApplyToTest
    {
        public UnityPlatformAttribute();
        public UnityPlatformAttribute(params RuntimePlatform[] include);

        public RuntimePlatform[] include { get; set; }
        public RuntimePlatform[] exclude { get; set; }

        public void ApplyToTest(NUnit.Framework.Internal.Test test);
    }
}
