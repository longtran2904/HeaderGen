#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline.Actions
{
    [ActiveInMode(TimelineModes.Default)]
    public abstract class MarkerAction : IAction
    {
        protected MarkerAction();

        public abstract bool Execute(IEnumerable<IMarker> markers);
        public abstract ActionValidity Validate(IEnumerable<IMarker> markers);
    }
}
