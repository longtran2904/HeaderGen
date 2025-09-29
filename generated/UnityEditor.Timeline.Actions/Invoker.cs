#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline.Actions
{
    public static class Invoker
    {

        public static bool Invoke<T>(this ActionContext context) where T : TimelineAction;
        public static bool Invoke<T>(this IEnumerable<TrackAsset> tracks) where T : TrackAction;
        public static bool Invoke<T>(this IEnumerable<TimelineClip> clips) where T : ClipAction;
        public static bool Invoke<T>(this IEnumerable<IMarker> markers) where T : MarkerAction;
        public static bool InvokeWithSelected<T>() where T : TimelineAction;
        public static bool InvokeWithSelectedClips<T>() where T : ClipAction;
        public static bool InvokeWithSelectedTracks<T>() where T : TrackAction;
        public static bool InvokeWithSelectedMarkers<T>() where T : MarkerAction;
    }
}
