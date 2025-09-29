#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro
{
    public static class TMP_FontAsset_CreationMenu
    {
        [MenuItem("Assets/Create/TextMeshPro/Font Asset Variant", False, 105)]
        public static void CreateFontAssetVariant();
        [MenuItem("Assets/Create/TextMeshPro/Font Asset #%F12", False, 100)]
        public static void CreateFontAsset();
    }
}
