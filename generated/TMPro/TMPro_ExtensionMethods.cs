#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
    public static class TMPro_ExtensionMethods
    {

        public static int[] ToIntArray(this string text);
        public static string ArrayToString(this char[] chars);
        public static string IntToString(this int[] unicodes);
        public static string IntToString(this int[] unicodes, int start, int length);
        public static int FindInstanceID<T>(this List<T> list, T target) where T : UnityEngine.Object;
        public static bool Compare(this Color32 a, Color32 b);
        public static bool CompareRGB(this Color32 a, Color32 b);
        public static bool Compare(this Color a, Color b);
        public static bool CompareRGB(this Color a, Color b);
        public static Color32 Multiply(this Color32 c1, Color32 c2);
        public static Color32 Tint(this Color32 c1, Color32 c2);
        public static Color32 Tint(this Color32 c1, float tint);
        public static Color MinAlpha(this Color c1, Color c2);
        public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy);
        public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy);
    }
}
