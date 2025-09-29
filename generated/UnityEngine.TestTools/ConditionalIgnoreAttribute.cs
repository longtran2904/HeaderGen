#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestTools
{
    public class ConditionalIgnoreAttribute : NUnitAttribute, IApplyToTest
    {

        public ConditionalIgnoreAttribute(string conditionKey, string ignoreReason);

        public void ApplyToTest(NUnit.Framework.Internal.Test test);
        public static void AddConditionalIgnoreMapping(string key, bool value);
    }
}
