#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector3EqualityComparer : IEqualityComparer<Vector3>
    {
        public Vector3EqualityComparer(float allowedError);

        public static Vector3EqualityComparer Instance { get; }

        public bool Equals(Vector3 expected, Vector3 actual);
        public int GetHashCode(Vector3 vec3);
    }
}
