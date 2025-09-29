#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public static class UndoExtensions
    {

        public static void RegisterContext(ActionContext context, string undoTitle);
        public static void RegisterTimeline(TimelineAsset asset, string undoTitle);
        public static void RegisterCompleteTimeline(TimelineAsset asset, string undoTitle);
        public static void RegisterTrack(TrackAsset asset, string undoTitle);
        public static void RegisterTracks(IEnumerable<TrackAsset> tracks, string undoTitle);
        public static void RegisterClip(TimelineClip clip, string undoTitle, bool includePlayableAsset = True);
        public static void RegisterPlayableAsset(PlayableAsset asset, string undoTitle);
        public static void RegisterClips(IEnumerable<TimelineClip> clips, string name, bool includePlayableAssets = True);
        public static void RegisterMarker(IMarker marker, string undoTitle);
        public static void RegisterMarkers(IEnumerable<IMarker> markers, string undoTitle);
    }
}
