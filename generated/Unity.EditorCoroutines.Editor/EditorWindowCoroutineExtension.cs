#region Unity.EditorCoroutines.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.EditorCoroutines.Editor.dll
#endregion

using System.Collections;
using UnityEditor;

namespace Unity.EditorCoroutines.Editor
{
    public static class EditorWindowCoroutineExtension
    {
        public static EditorCoroutine StartCoroutine(this EditorWindow window, IEnumerator routine);
        public static void StopCoroutine(this EditorWindow window, EditorCoroutine coroutine);
    }
}
