#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector4ComparerWithEqualsOperator : IEqualityComparer<Vector4>
    {

        public static Vector4ComparerWithEqualsOperator Instance { get; }

        public bool Equals(Vector4 expected, Vector4 actual);
        public int GetHashCode(Vector4 vec4);
    }
}
