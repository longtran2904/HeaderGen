#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public static class TMP_Math
    {
        public static Vector2 MAX_16BIT;
        public static Vector2 MIN_16BIT;
        public const float FLOAT_MAX = 32767;
        public const float FLOAT_MIN = -32767;
        public const int INT_MAX = 2147483647;
        public const int INT_MIN = -2147483647;
        public const float FLOAT_UNSET = -32767;
        public const int INT_UNSET = -32767;

        public static bool Approximately(float a, float b);
        public static int Mod(int a, int b);
    }
}
