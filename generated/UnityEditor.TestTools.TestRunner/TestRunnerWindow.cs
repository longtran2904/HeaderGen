#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

namespace UnityEditor.TestTools.TestRunner
{
    public class TestRunnerWindow : EditorWindow, IHasCustomMenu
    {

        public TestRunnerWindow();

        [MenuItem("Window/General/Test Runner", False, 201, False)]
        public static void ShowWindow();
        public void AddItemsToMenu(GenericMenu menu);
    }
}
