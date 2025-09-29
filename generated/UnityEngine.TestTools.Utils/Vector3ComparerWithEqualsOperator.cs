#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector3ComparerWithEqualsOperator : IEqualityComparer<Vector3>
    {

        public static Vector3ComparerWithEqualsOperator Instance { get; }

        public bool Equals(Vector3 expected, Vector3 actual);
        public int GetHashCode(Vector3 vec3);
    }
}
