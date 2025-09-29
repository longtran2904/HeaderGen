#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Recorder
{
    public static class BindingManager
    {
        public static UnityEngine.Object Get(string id);
        public static void Duplicate(string id, string newId);
        public static void Set(string id, UnityEngine.Object obj);
    }
}
