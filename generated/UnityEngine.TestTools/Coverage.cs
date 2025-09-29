#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.TestTools
{
    [NativeClass("ScriptingCoverage")]
    [NativeType("Runtime/Scripting/ScriptingCoverage.h")]
    public static class Coverage
    {

        public static bool enabled { get; set; }

        public static CoveredSequencePoint[] GetSequencePointsFor(MethodBase method);
        public static CoveredMethodStats GetStatsFor(MethodBase method);
        public static CoveredMethodStats[] GetStatsFor(MethodBase[] methods);
        public static CoveredMethodStats[] GetStatsFor(Type type);
        [FreeFunction("ScriptingCoverageGetStatsForAllCoveredMethodsFromScripting", ThrowsException = True)]
        public static CoveredMethodStats[] GetStatsForAllCoveredMethods();
        public static void ResetFor(MethodBase method);
        [FreeFunction("ScriptingCoverageResetAllFromScripting", ThrowsException = True)]
        public static void ResetAll();
    }
}
