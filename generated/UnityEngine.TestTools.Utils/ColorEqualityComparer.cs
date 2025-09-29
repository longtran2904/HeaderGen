#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class ColorEqualityComparer : IEqualityComparer<Color>
    {

        public ColorEqualityComparer(float error);

        public static ColorEqualityComparer Instance { get; }

        public bool Equals(Color expected, Color actual);
        public int GetHashCode(Color color);
    }
}
