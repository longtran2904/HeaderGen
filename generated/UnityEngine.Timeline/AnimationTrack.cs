#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [ExcludeFromPreset]
    [TimelineHelpURL(typeof(AnimationTrack))]
    [TrackBindingType(typeof(Animator))]
    [TrackClipType(typeof(AnimationPlayableAsset), False)]
    public class AnimationTrack : TrackAsset, ILayerable
    {

        public AnimationTrack();

        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public Vector3 eulerAngles { get; set; }
        [Obsolete("applyOffset is deprecated. Use trackOffset instead", True)]
        public bool applyOffsets { get; set; }
        public TrackOffset trackOffset { get; set; }
        public MatchTargetFields matchTargetFields { get; set; }
        public AnimationClip infiniteClip { get; }
        public AvatarMask avatarMask { get; set; }
        public bool applyAvatarMask { get; set; }
        public override IEnumerable<PlayableBinding> outputs { get; }
        public bool inClipMode { get; }
        public Vector3 infiniteClipOffsetPosition { get; set; }
        public Quaternion infiniteClipOffsetRotation { get; set; }
        public Vector3 infiniteClipOffsetEulerAngles { get; set; }
        public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
        public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", True)]
        public Vector3 openClipOffsetPosition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", True)]
        public Quaternion openClipOffsetRotation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", True)]
        public Vector3 openClipOffsetEulerAngles { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", True)]
        public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", True)]
        public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; }

        public TimelineClip CreateClip(AnimationClip clip);
        public void CreateInfiniteClip(string infiniteClipName);
        public TimelineClip CreateRecordableClip(string animClipName);
        protected override void OnCreateClip(TimelineClip clip);
        protected internal override int CalculateItemsHash();
        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver);
    }
}
