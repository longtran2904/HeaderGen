#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline.Actions
{
    public struct ActionContext
    {
        public TimelineAsset timeline;
        public PlayableDirector director;
        public double? invocationTime;

        public IEnumerable<TrackAsset> tracks { get; set; }
        public IEnumerable<TimelineClip> clips { get; set; }
        public IEnumerable<IMarker> markers { get; set; }
    }
}
