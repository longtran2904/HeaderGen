#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [ExcludeFromPreset]
    [TimelineHelpURL(typeof(ActivationTrack))]
    [TrackBindingType(typeof(GameObject))]
    [TrackClipType(typeof(ActivationPlayableAsset))]
    public class ActivationTrack : TrackAsset
    {

        public ActivationTrack();

        public PostPlaybackState postPlaybackState { get; set; }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount);
        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver);
        protected override void OnCreateClip(TimelineClip clip);
        public enum PostPlaybackState
        {

            Active = 0,
            Inactive = 1,
            Revert = 2,
            LeaveAsIs = 3
        }
    }
}
