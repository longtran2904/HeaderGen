#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace TMPro
{
    public class TMP_PreBuildProcessor : IOrderedCallback, IPreprocessBuildWithReport
    {

        public TMP_PreBuildProcessor();

        public int callbackOrder { get; }

        public void OnPreprocessBuild(BuildReport report);
    }
}
