#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

namespace UnityEditor.Timeline.Actions
{
    [ActiveInMode(TimelineModes.Default)]
    public abstract class TimelineAction : IAction
    {

        protected TimelineAction();

        public abstract bool Execute(ActionContext context);
        public abstract ActionValidity Validate(ActionContext context);
    }
}
