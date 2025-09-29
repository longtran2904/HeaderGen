#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class FloatEqualityComparer : IEqualityComparer<float>
    {

        public FloatEqualityComparer(float allowedError);

        public static FloatEqualityComparer Instance { get; }

        public bool Equals(float expected, float actual);
        public int GetHashCode(float value);
    }
}
