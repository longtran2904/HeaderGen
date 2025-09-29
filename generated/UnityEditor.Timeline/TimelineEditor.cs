#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public static class TimelineEditor
    {

        public static PlayableDirector inspectedDirector { get; }
        public static PlayableDirector masterDirector { get; }
        public static TimelineAsset inspectedAsset { get; }
        public static TimelineAsset masterAsset { get; }
        [Obsolete("playableDirector is ambiguous. Please select either inspectedDirector or masterDirector instead.", False)]
        public static PlayableDirector playableDirector { get; }
        [Obsolete("timelineAsset is ambiguous. Please select either inspectedAsset or masterAsset instead.", False)]
        public static TimelineAsset timelineAsset { get; }
        public static TimelineClip[] selectedClips { get; set; }
        public static TimelineClip selectedClip { get; set; }

        public static TimelineEditorWindow GetWindow();
        public static TimelineEditorWindow GetOrCreateWindow();
        public static void Refresh(RefreshReason reason);
        public static double GetInspectedTimeFromMasterTime(double masterTime);
        public static double GetMasterTimeFromInspectedTime(double inspectedTime);
    }
}
