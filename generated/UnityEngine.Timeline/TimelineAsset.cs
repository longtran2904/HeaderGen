#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [ExcludeFromPreset]
    [TimelineHelpURL(typeof(TimelineAsset))]
    public class TimelineAsset : PlayableAsset, IPropertyPreview, ISerializationCallbackReceiver, ITimelineClipAsset
    {
        public TimelineAsset();

        public EditorSettings editorSettings { get; }
        public override double duration { get; }
        public double fixedDuration { get; set; }
        public DurationMode durationMode { get; set; }
        public override IEnumerable<PlayableBinding> outputs { get; }
        public ClipCaps clipCaps { get; }
        public int outputTrackCount { get; }
        public int rootTrackCount { get; }
        public MarkerTrack markerTrack { get; }

        public TrackAsset GetRootTrack(int index);
        public IEnumerable<TrackAsset> GetRootTracks();
        public TrackAsset GetOutputTrack(int index);
        public IEnumerable<TrackAsset> GetOutputTracks();
        public override Playable CreatePlayable(PlayableGraph graph, GameObject go);
        public void GatherProperties(PlayableDirector director, IPropertyCollector driver);
        public void CreateMarkerTrack();
        public TrackAsset CreateTrack(Type type, TrackAsset parent, string name);
        public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new();
        public T CreateTrack<T>(string trackName) where T : TrackAsset, new();
        public T CreateTrack<T>() where T : TrackAsset, new();
        public bool DeleteClip(TimelineClip clip);
        public bool DeleteTrack(TrackAsset track);

        [Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
        public enum MediaType
        {
            Animation = 0,
            Audio = 1,
            Texture = 2,
            [Obsolete("Use Texture MediaType instead. (UnityUpgradable) -> UnityEngine.Timeline.TimelineAsset/MediaType.Texture", False)]
            Video = 2,
            Script = 3,
            Hybrid = 4,
            Group = 5
        }
        public enum DurationMode
        {
            BasedOnClips = 0,
            FixedLength = 1
        }
        public class EditorSettings
        {
            public EditorSettings();

            [Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", False)]
            public float fps { get; set; }
            public double frameRate { get; set; }
            public bool scenePreview { get; set; }

            public void SetStandardFrameRate(StandardFrameRates enumValue);
        }
    }
}
