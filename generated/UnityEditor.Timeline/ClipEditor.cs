#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public class ClipEditor
    {

        public ClipEditor();

        public virtual ClipDrawOptions GetClipOptions(TimelineClip clip);
        public virtual void DrawBackground(TimelineClip clip, ClipBackgroundRegion region);
        public virtual void OnCreate(TimelineClip clip, TrackAsset track, TimelineClip clonedFrom);
        public string GetErrorText(TimelineClip clip);
        public Color GetDefaultHighlightColor(TimelineClip clip);
        public virtual void OnClipChanged(TimelineClip clip);
        public virtual void GetSubTimelines(TimelineClip clip, PlayableDirector director, List<PlayableDirector> subTimelines);
    }
}
