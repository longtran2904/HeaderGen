#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro
{
    public class TMP_PackageUtilities : Editor
    {
        public TMP_PackageUtilities();

        [MenuItem("Window/TextMeshPro/Import TMP Essential Resources", False, 2050)]
        public static void ImportProjectResourcesMenu();
        [MenuItem("Window/TextMeshPro/Import TMP Examples and Extras", False, 2051)]
        public static void ImportExamplesContentMenu();
    }
}
