#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;

namespace UnityEditor.Timeline.Actions
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = False)]
    public class ApplyDefaultUndoAttribute : Attribute
    {
        public string UndoTitle;

        public ApplyDefaultUndoAttribute(string undoTitle = null);
    }
}
