#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;

namespace UnityEditor.Timeline.Actions
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ActiveInModeAttribute : Attribute
    {
        public ActiveInModeAttribute(TimelineModes timelineModes);

        public TimelineModes modes { get; }
    }
}
