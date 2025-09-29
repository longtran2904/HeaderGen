#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEditor.Callbacks;

namespace TMPro
{
    public class TMP_PostBuildProcessHandler
    {
        public TMP_PostBuildProcessHandler();

        [PostProcessBuild(10000)]
        public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject);
    }
}
