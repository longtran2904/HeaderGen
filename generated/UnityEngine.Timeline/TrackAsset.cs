#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [IgnoreOnPlayableTrack]
    public abstract class TrackAsset : PlayableAsset, ICurvesOwner, IPropertyPreview, ISerializationCallbackReceiver
    {

        [HideInInspector]
        [SerializeField]
        protected internal List<TimelineClip> m_Clips;

        protected TrackAsset();

        public double start { get; }
        public double end { get; }
        public sealed override double duration { get; }
        public bool muted { get; set; }
        public bool mutedInHierarchy { get; }
        public TimelineAsset timelineAsset { get; }
        public PlayableAsset parent { get; }
        public virtual bool isEmpty { get; }
        public bool hasClips { get; }
        public bool hasCurves { get; }
        public bool isSubTrack { get; }
        public override IEnumerable<PlayableBinding> outputs { get; }
        public AnimationClip curves { get; }
        public bool locked { get; set; }
        public bool lockedInHierarchy { get; }
        public bool supportsNotifications { get; }

        protected virtual void OnBeforeTrackSerialize();
        protected virtual void OnAfterTrackDeserialize();
        public IEnumerable<TimelineClip> GetClips();
        public IEnumerable<TrackAsset> GetChildTracks();
        public void CreateCurves(string curvesClipName);
        public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount);
        public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go);
        public TimelineClip CreateDefaultClip();
        public TimelineClip CreateClip<T>() where T : ScriptableObject, IPlayableAsset;
        public bool DeleteClip(TimelineClip clip);
        public IMarker CreateMarker(Type type, double time);
        public T CreateMarker<T>(double time) where T : ScriptableObject, IMarker;
        public bool DeleteMarker(IMarker marker);
        public IEnumerable<IMarker> GetMarkers();
        public int GetMarkerCount();
        public IMarker GetMarker(int idx);
        public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver);
        protected virtual void OnCreateClip(TimelineClip clip);
        protected internal virtual int CalculateItemsHash();
        protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip);
        public virtual bool CanCreateTrackMixer();
        protected static int GetAnimationClipHash(AnimationClip clip);
    }
}
