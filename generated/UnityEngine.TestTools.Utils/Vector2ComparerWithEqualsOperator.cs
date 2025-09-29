#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector2ComparerWithEqualsOperator : IEqualityComparer<Vector2>
    {
        public static Vector2ComparerWithEqualsOperator Instance { get; }

        public bool Equals(Vector2 expected, Vector2 actual);
        public int GetHashCode(Vector2 vec2);
    }
}
