#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Timeline
{
    public sealed class TimelineNavigator
    {
        public SequenceContext GetCurrentContext();
        public SequenceContext GetParentContext();
        public SequenceContext GetRootContext();
        public IEnumerable<SequenceContext> GetChildContexts();
        public IEnumerable<SequenceContext> GetBreadcrumbs();
        public void NavigateTo(SequenceContext context);
    }
}
