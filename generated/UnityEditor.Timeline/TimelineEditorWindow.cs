#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public abstract class TimelineEditorWindow : EditorWindow
    {

        protected TimelineEditorWindow();

        public abstract TimelineNavigator navigator { get; }
        public abstract bool locked { get; set; }

        public abstract void SetTimeline(TimelineAsset sequence);
        public abstract void SetTimeline(PlayableDirector director);
        public abstract void ClearTimeline();
    }
}
