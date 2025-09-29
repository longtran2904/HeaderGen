#region UnityEditor.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.TextCoreTextEngineModule.dll
#endregion

using UnityEngine;
using UnityEngine.TextCore.Text;

namespace UnityEditor.TextCore.Text
{
    public class FontAssetCreatorWindow : EditorWindow
    {
        public FontAssetCreatorWindow();

        public static void ShowFontAtlasCreatorWindow(Font font);
        public static void ShowFontAtlasCreatorWindow(FontAsset fontAsset);
        public void OnEnable();
        public void OnDisable();
        public void OnGUI();
        public void Update();
        public FontFeatureTable GetKerningTable();
    }
}
