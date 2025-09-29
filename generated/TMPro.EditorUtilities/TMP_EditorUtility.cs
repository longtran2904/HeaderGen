#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    public static class TMP_EditorUtility
    {

        public static string packageRelativePath { get; }
        public static string packageFullPath { get; }

        public static void RepaintAll();
        public static T CreateAsset<T>(string name) where T : ScriptableObject;
        public static Material[] FindMaterialReferences(TMP_FontAsset fontAsset);
        public static TMP_FontAsset FindMatchingFontAsset(Material mat);
        public static string GetDecimalCharacterSequence(int[] characterSet);
        public static string GetUnicodeCharacterSequence(int[] characterSet);
        public static void DrawBox(Rect rect, float thickness, Color color);
        public static int GetHorizontalAlignmentGridValue(int value);
        public static int GetVerticalAlignmentGridValue(int value);
        public static void DrawColorProperty(Rect rect, SerializedProperty property);
        public static bool EditorToggle(Rect position, bool value, GUIContent content, GUIStyle style);
    }
}
