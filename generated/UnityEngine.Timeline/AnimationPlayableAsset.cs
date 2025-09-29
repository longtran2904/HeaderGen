#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [NotKeyable]
    public class AnimationPlayableAsset : PlayableAsset, IPropertyPreview, ISerializationCallbackReceiver, ITimelineClipAsset
    {

        public AnimationPlayableAsset();

        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public Vector3 eulerAngles { get; set; }
        public bool useTrackMatchFields { get; set; }
        public MatchTargetFields matchTargetFields { get; set; }
        public bool removeStartOffset { get; set; }
        public bool applyFootIK { get; set; }
        public LoopMode loop { get; set; }
        public AnimationClip clip { get; set; }
        public override double duration { get; }
        public override IEnumerable<PlayableBinding> outputs { get; }
        public ClipCaps clipCaps { get; }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go);
        public void LiveLink();
        public void ResetOffsets();
        public void GatherProperties(PlayableDirector director, IPropertyCollector driver);
        public enum LoopMode
        {

            [Tooltip("Use the loop time setting from the source AnimationClip.")]
            UseSourceAsset = 0,
            [Tooltip("The source AnimationClip loops during playback.")]
            On = 1,
            [Tooltip("The source AnimationClip does not loop during playback.")]
            Off = 2
        }
    }
}
