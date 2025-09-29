#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    public static class TMPro_CreateObjectMenu
    {
        [MenuItem("GameObject/UI/Button - TextMeshPro", False, 2031)]
        public static void AddButton(MenuCommand menuCommand);
        [MenuItem("GameObject/UI/Dropdown - TextMeshPro", False, 2036)]
        public static void AddDropdown(MenuCommand menuCommand);
        public static GameObject CreateNewUI();
        public static GameObject GetOrCreateCanvasGameObject();
    }
}
