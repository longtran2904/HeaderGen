#region Unity.EditorCoroutines.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.EditorCoroutines.Editor.dll
#endregion

using System.Collections;

namespace Unity.EditorCoroutines.Editor
{
    public static class EditorCoroutineUtility
    {
        public static EditorCoroutine StartCoroutine(IEnumerator routine, object owner);
        public static EditorCoroutine StartCoroutineOwnerless(IEnumerator routine);
        public static void StopCoroutine(EditorCoroutine coroutine);
    }
}
