#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    public class TMPro_FontAssetCreatorWindow : EditorWindow
    {
        public TMPro_FontAssetCreatorWindow();

        [MenuItem("Window/TextMeshPro/Font Asset Creator", False, 2025)]
        public static void ShowFontAtlasCreatorWindow();
        public static void ShowFontAtlasCreatorWindow(Font sourceFontFile);
        public static void ShowFontAtlasCreatorWindow(TMP_FontAsset fontAsset);
        public void OnEnable();
        public void OnDisable();
        public void OnGUI();
        public void Update();
        public TMP_FontFeatureTable GetKerningTable();
    }
}
