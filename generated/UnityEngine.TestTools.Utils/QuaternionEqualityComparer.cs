#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
    {
        public QuaternionEqualityComparer(float allowedError);

        public static QuaternionEqualityComparer Instance { get; }

        public bool Equals(Quaternion expected, Quaternion actual);
        public int GetHashCode(Quaternion quaternion);
    }
}
