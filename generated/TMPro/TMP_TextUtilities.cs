#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public static class TMP_TextUtilities
    {

        public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera);
        public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor);
        public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera);
        public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly);
        public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera);
        public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly);
        public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly);
        public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera);
        public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera);
        public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera);
        public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera);
        public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera);
        public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint);
        public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point);
        public static char ToLowerFast(char c);
        public static char ToUpperFast(char c);
        public static int GetHashCode(string s);
        public static int GetSimpleHashCode(string s);
        public static uint GetSimpleHashCodeLowercase(string s);
        public static int HexToInt(char hex);
        public static int StringHexToInt(string s);
    }
}
